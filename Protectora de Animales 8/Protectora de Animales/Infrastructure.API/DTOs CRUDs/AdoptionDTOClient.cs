using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.API
{
    public class AdoptionDTOClient : BaseDTOClient<AdoptionDTO>
    {
        protected override string _endpoint => "adoption";
        public AdoptionDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }
    }
}
