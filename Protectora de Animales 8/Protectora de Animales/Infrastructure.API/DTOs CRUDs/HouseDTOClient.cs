using System;

namespace Infrastructure.API.DTOs_CRUDs
{
    public class HouseDTOClient : BaseDTOClient<HouseDTOClient>
    {
        protected override string _endpoint => "houses";
        public HouseDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }
        public override Task<HouseDTOClient> PostAsync(object data)
        {
            return base.PostAsync(data);
        }
    }
}
