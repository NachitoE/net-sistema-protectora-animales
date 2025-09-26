using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.API.DTOs_CRUDs
{
    public class SightingDTOClient: BaseDTOClient<SightingDTOClient>
    {
        protected override string _endpoint => "sightings";
        public SightingDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }
        public override Task<SightingDTOClient> PostAsync(object data)
        {
            return base.PostAsync(data);
        }
    }
    
}
