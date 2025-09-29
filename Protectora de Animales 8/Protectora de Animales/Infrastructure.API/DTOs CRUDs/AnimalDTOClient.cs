using DTOs;

namespace Infrastructure.API
{
    public class AnimalDTOClient : BaseDTOClient<AnimalDTO>
    {
        protected override string _endpoint => "animals";
        public AnimalDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }

        public async Task<List<AnimalDTO>> GetAllAvailableAnimalsAsync() => await _apiHttpClient.GetAsync<List<AnimalDTO>>($"{_endpoint}/available");
        public async Task<AnimalDTO> AssignResponsible(string animalId, string userId) => await _apiHttpClient.PutAsync<AnimalDTO>($"{_endpoint}/{animalId}/assign-responsible", userId);
    }
}
