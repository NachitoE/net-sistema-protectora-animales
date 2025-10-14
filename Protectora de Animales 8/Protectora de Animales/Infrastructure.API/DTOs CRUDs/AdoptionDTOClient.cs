using DTOs;


namespace Infrastructure.API
{
    public class AdoptionDTOClient : BaseDTOClient<AdoptionDTO>
    {
        protected override string _endpoint => "adoptions";
        public AdoptionDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }
        /*
        public async Task<ApiResult<List<AdoptionDTO>>> GetByUserIdAsync(string userId)
            => await _apiHttpClient.GetAsync<List<AdoptionDTO>>($"{_endpoint}/user/{userId}");
        public async Task<ApiResult<List<AdoptionDTO>>> GetByAnimalIdAsync(string animalId)
            => await _apiHttpClient.GetAsync<List<AdoptionDTO>>($"{_endpoint}/animal/{animalId}");
        */
        public async Task<ApiResult<AdoptionDTO>> PostAsync(AdoptionRequestDTO data)
        {
            return await base.PostAsync(data);
        }
    }
}
