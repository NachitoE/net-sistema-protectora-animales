using Newtonsoft.Json;
using System.Net;
using System.Text;


namespace Infrastructure.API
{
    public class APIHttpClient : IApiHttpClient, IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public APIHttpClient(string baseUrl)
        {
            _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl),
                Timeout = TimeSpan.FromSeconds(30)
            };
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<ApiResult<T>> GetAsync<T>(string endpoint)
        {
            return await ExecuteRequest<T>(async () => await _httpClient.GetAsync(endpoint));
        }

        public async Task<ApiResult<T>> PostAsync<T>(string endpoint, object data)
        {
            return await ExecuteRequest<T>(async () =>
            {
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                return await _httpClient.PostAsync(endpoint, content);
            });
        }

        public async Task<ApiResult<T>> PutAsync<T>(string endpoint, object data)
        {
            return await ExecuteRequest<T>(async () =>
            {
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                return await _httpClient.PutAsync(endpoint, content);
            });
        }

        public async Task<ApiResult<bool>> DeleteAsync(string endpoint)
        {
            var result = await ExecuteRequest<object>(async () => await _httpClient.DeleteAsync(endpoint));

            if (result.Success)
            {
                return ApiResult<bool>.FromSuccess(true, "Recurso eliminado exitosamente");
            }

            // DELETE 404 => No existe => success?
            if (result.StatusCode == HttpStatusCode.NotFound)
            {
                return ApiResult<bool>.FromSuccess(false, "Recurso no encontrado");
            }

            return ApiResult<bool>.FromError(result.Message, "", result.StatusCode);
        }

        /// <summary>
        /// Método común para ejecutar requests HTTP y manejar respuestas
        /// </summary>
        private async Task<ApiResult<T>> ExecuteRequest<T>(Func<Task<HttpResponseMessage>> requestFunc)
        {
            try
            {
                var response = await requestFunc();

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    if (string.IsNullOrEmpty(content))
                    {
                        return ApiResult<T>.FromError("Respuesta vacía del servidor");
                    }

                    try
                    {
                        var data = JsonConvert.DeserializeObject<T>(content);
                        return data != null
                            ? ApiResult<T>.FromSuccess(data)
                            : ApiResult<T>.FromError("No se pudo procesar la respuesta del servidor");
                    }
                    catch (JsonException)
                    {
                        return ApiResult<T>.FromError("Error al procesar la respuesta del servidor");
                    }
                }

                // Usar el mensaje del servidor si está disponible
                var errorMessage = await ExtractServerMessage(response);
                // Update the line causing the error in the ExecuteRequest<T> method
                return ApiResult<T>.FromError(errorMessage, errorDetails: null, statusCode: response.StatusCode);
            }
            catch (HttpRequestException)
            {
                return ApiResult<T>.FromError("No se pudo conectar con el servidor");
            }
            catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
            {
                return ApiResult<T>.FromError("La solicitud tardó demasiado tiempo");
            }
            catch (Exception)
            {
                return ApiResult<T>.FromError("Error inesperado al comunicarse con el servidor");
            }
        }

        /// <summary>
        /// Extrae el mensaje de error del servidor, usando la estructura { error: "message" }
        /// </summary>
        private async Task<string> ExtractServerMessage(HttpResponseMessage response)
        {
            try
            {
                var content = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(content))
                {
                    return GetFallbackMessage(response.StatusCode);
                }

                // error?
                var errorObj = JsonConvert.DeserializeAnonymousType(content, new { error = "" });

                if (!string.IsNullOrEmpty(errorObj?.error))
                {
                    return errorObj.error;
                }

                // estructura no esperada => fallback
                if (content.Length < 200)
                {
                    return content;
                }

                return GetFallbackMessage(response.StatusCode);
            }
            catch
            {
                return GetFallbackMessage(response.StatusCode);
            }
        }

        /// <summary>
        /// Mensaje de fallback cuando no se puede extraer el mensaje del servidor
        /// </summary>
        private string GetFallbackMessage(HttpStatusCode statusCode)
        {
            return statusCode switch
            {
                HttpStatusCode.BadRequest => "Datos inválidos",
                HttpStatusCode.Unauthorized => "No autorizado",
                HttpStatusCode.NotFound => "Recurso no encontrado",
                HttpStatusCode.InternalServerError => "Error interno del servidor",
                _ => $"Error del servidor ({(int)statusCode})"
            };
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
