using DTOs;
using System.Net.Http.Json;

namespace Services
{
    public class AuthServiceClient
    {
        private readonly HttpClient _httpClient;

        public AuthServiceClient()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7056/") };
        }

        public async Task<UserRegisterResponseDTO> RegisterAsync(UserRegisterRequestDTO request)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/auth/register", request);

            if (!response.IsSuccessStatusCode)
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                return new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = $"Error en API: {response.StatusCode}. Contenido: {errorContent}"
                };
            }

            try
            {
                return await response.Content.ReadFromJsonAsync<UserRegisterResponseDTO>()
                       ?? new UserRegisterResponseDTO
                       {
                           Success = false,
                           Message = "Respuesta vacía desde la API"
                       };
            }
            catch (Exception ex)
            {
                string raw = await response.Content.ReadAsStringAsync();
                return new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = $"Error deserializando: {ex.Message}. Contenido: {raw}"
                };
            }
        }
    }
}