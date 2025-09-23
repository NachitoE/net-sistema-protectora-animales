using DTOs.House;
using DTOs;
using System.Net.Http.Json;

namespace Infrastructure.API
{
    public class HouseClient
    {
        private HttpClient _http;

        public HouseClient()
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri("https://localhost:5001/api/");
        }

        public async Task<ResponseDTO> RegisterAsync(HouseRegisterRequestDTO request)
        {
            var response = await _http.PostAsJsonAsync("house", request);
            return await response.Content.ReadFromJsonAsync<ResponseDTO>();
        }

        public async Task<ResponseDTO> UpdateAsync(string id, HouseRegisterRequestDTO request)
        {
            var response = await _http.PutAsJsonAsync($"house/{id}", request);
            return await response.Content.ReadFromJsonAsync<ResponseDTO>();
        }

        public async Task<ResponseDTO> DeleteAsync(string id)
        {
            var response = await _http.DeleteAsync($"house/{id}");
            return await response.Content.ReadFromJsonAsync<ResponseDTO>();
        }
    }
}
