using DTOs;

namespace Infrastructure.API
{
    public class UserDTOClient : BaseDTOClient<UserDTO>
    {
        protected override string _endpoint => "users";
        public UserDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient) { }
        
        public async Task<List<UserDTO>> GetAvailableToAdoptAsync() => await _apiHttpClient.GetAsync<List<UserDTO>>($"{_endpoint}/available-to-adopt");
        public async Task<List<AnimalDTO>> GetUserAnimalsAsync(string userId) => await _apiHttpClient.GetAsync<List<AnimalDTO>>($"{_endpoint}/{userId}/animals");
    }
}
