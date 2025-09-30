using DTOs;
using DTOs.User;

namespace Infrastructure.API
{
    public class UserDTOClient : BaseDTOClient<UserDTO>
    {
        protected override string _endpoint => "users";
        public UserDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient) { }
        
        public async Task<ApiResult<List<UserDTO>>> GetAvailableToAdoptAsync() => await _apiHttpClient.GetAsync<List<UserDTO>>($"{_endpoint}/available-to-adopt");
        public async Task<ApiResult<List<AnimalDTO>>> GetUserAnimalsAsync(string userId) => await _apiHttpClient.GetAsync<List<AnimalDTO>>($"{_endpoint}/{userId}/animals");
        public async Task<ApiResult<UserRemainingCapacityResponseDTO>> GetUserRemainingCapacity(string userId) =>
            await _apiHttpClient.GetAsync<UserRemainingCapacityResponseDTO>($"{_endpoint}/{userId}/remaining-capacity");

    }
}
