using DTOs;

namespace Infrastructure.API
{
    public class AnimalDTOClient : BaseDTOClient<AnimalDTO>
    {
        protected override string _endpoint => "animals";
        
        public AnimalDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }

        public async Task<ApiResult<List<AnimalDTO>>> GetAllAvailableAnimalsAsync() 
            => await _apiHttpClient.GetAsync<List<AnimalDTO>>($"{_endpoint}/available");

        public async Task<ApiResult<List<AnimalDTO>>> GetAllAvailableForAdoptAnimalsAsync()
            => await _apiHttpClient.GetAsync<List<AnimalDTO>>($"{_endpoint}/available-for-adopt");

        public async Task<ApiResult<AnimalDTO>> AssignResponsible(string animalId, string userId) 
            => await _apiHttpClient.PutAsync<AnimalDTO>($"{_endpoint}/{animalId}/assign-responsible", userId);
        public async Task<ApiResult<List<AnimalDTO>>> GetMyAnimalsAsync()
            => await _apiHttpClient.GetAsync<List<AnimalDTO>>($"{_endpoint}/my-animals");
    }
}
