using DTOs.User;
using System.Net.Http.Json;

namespace Infrastructure.API.Clients
{
    public class TransitoClient
    {
        private readonly HttpClient _httpClient;

        public TransitoClient()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7056/") };
        }

        public async Task<TransitoRegisterResponseDTO> RegisterAsync(TransitoRegisterRequestDTO request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/transito/register", request);
            string content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                // Solo devuelvo el error como DTO, no hago MessageBox
                return new TransitoRegisterResponseDTO
                {
                    Success = false,
                    Message = $"Error API {response.StatusCode}: {content}"
                };
            }

            try
            {
                var result = System.Text.Json.JsonSerializer.Deserialize<TransitoRegisterResponseDTO>(content);
                if (result == null)
                    return new TransitoRegisterResponseDTO
                    {
                        Success = false,
                        Message = "Respuesta JSON vacía desde la API"
                    };

                return result;
            }
            catch (System.Text.Json.JsonException)
            {
                return new TransitoRegisterResponseDTO
                {
                    Success = false,
                    Message = $"Respuesta inválida de la API: {content}"
                };
            }
        }
    }

    public class TransitoRegisterResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
