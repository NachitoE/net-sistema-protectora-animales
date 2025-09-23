using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using DTOs.House;



namespace Services
{
    public class HouseServiceClient
    {
        private readonly HttpClient _httpClient;

        public HouseServiceClient()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7056/") };
        }

        public async Task<HouseRegisterResponseDTO> RegisterAsync(HouseRegisterRequestDTO request)
        {
            var response = await _httpClient.PostAsJsonAsync("transito/register", request);

            if (!response.IsSuccessStatusCode)
            {
                return new HouseRegisterResponseDTO
                {
                    Success = false,
                    Message = $"Error en API: {response.StatusCode}"
                };
            }

            return await response.Content.ReadFromJsonAsync<HouseRegisterResponseDTO>()
                   ?? new HouseRegisterResponseDTO
                   {
                       Success = false,
                       Message = "Respuesta vacía desde la API"
                   };
        }
    }
}
