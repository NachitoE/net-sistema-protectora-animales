using DTOs;
using System;

namespace Infrastructure.API.DTOs_CRUDs
{
    public class HouseDTOClient : BaseDTOClient<HouseDTO>
    {
        protected override string _endpoint => "houses";
        public HouseDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }
    }
}
