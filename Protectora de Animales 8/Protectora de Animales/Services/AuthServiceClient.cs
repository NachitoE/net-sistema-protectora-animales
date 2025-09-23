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
                    return new UserRegisterResponseDTO
                    {
                        Success = false,
                        Message = $"Error en API: {response.StatusCode}"
                    };
                }

                return await response.Content.ReadFromJsonAsync<UserRegisterResponseDTO>()
                       ?? new UserRegisterResponseDTO
                       {
                           Success = false,
                           Message = "Respuesta vacía desde la API"
                       };
            }
        }
    }


