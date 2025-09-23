using DTOs.User;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.API
{
    public class TransitoClient
    {
        private readonly HttpClient _http;

        public TransitoClient()
        {
            _http = new HttpClient();
            _http.BaseAddress = new System.Uri("https://localhost:5001/api/");
        }

        public async Task<ResponseDTO> RegisterAsync(TransitoRegisterRequestDTO request)
        {
            var response = await _http.PostAsJsonAsync("transito/register", request);
            return await response.Content.ReadFromJsonAsync<ResponseDTO>();
        }
    }
}
