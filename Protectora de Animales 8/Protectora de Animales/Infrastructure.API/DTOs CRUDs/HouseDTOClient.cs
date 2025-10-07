using DTOs;
using DTOs.House;
using System.Threading.Tasks;

namespace Infrastructure.API.DTOs_CRUDs
{
    public class HouseDTOClient : BaseDTOClient<HouseDTO>
    {
        protected override string _endpoint => "houses";
        public HouseDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }
        public async Task<ApiResult<HouseDTO>> ChangeCapacity(HouseChangeCapacityDTO houseChangeCapacityDTO)
        {
            var res = await _apiHttpClient.PutAsync<HouseDTO>($"/{_endpoint}/capacity", houseChangeCapacityDTO);
            return res;
        }
        public async Task<ApiResult<HouseDTO>> GetHouseByUserId(string userId)
        { 
            var res = await _apiHttpClient.GetAsync<HouseDTO>($"/{_endpoint}/user-house/{userId}");
            return res;
        }
    }
}
