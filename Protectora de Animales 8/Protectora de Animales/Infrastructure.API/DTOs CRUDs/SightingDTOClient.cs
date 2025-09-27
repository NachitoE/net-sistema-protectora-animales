using DTOs.Sighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.API.DTOs_CRUDs
{
    public class SightingDTOClient: BaseDTOClient<SightingDTO>
    {
        protected override string _endpoint => "sightings";
        public SightingDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }
        public override Task<SightingDTO> PostAsync(object data)
        {
            return base.PostAsync(data);
        }

        public Task<List<SightingDTO>> GetAllSightingsAsync()
        {
            return GetAllAsync();
        }

        public Task<SightingDTO> UpdateSighting(string id, string nuevoEstado)
        {
            var data = new
            {
                Id = id,
                SightingState = nuevoEstado
            };

            return PutAsync(id, data);
        }
    }
    
}
