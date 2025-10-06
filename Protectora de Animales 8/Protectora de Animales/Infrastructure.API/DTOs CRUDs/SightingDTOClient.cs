using DTOs;
using Helpers;


namespace Infrastructure.API.DTOs_CRUDs
{
    public class SightingDTOClient: BaseDTOClient<SightingDTO>
    {
        protected override string _endpoint => "sightings";
        public SightingDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }

        public Task<ApiResult<SightingDTO>> UpdateSighting(string id, string nuevoEstado)
        {
            var data = new
            {
                Id = id,
                SightingState = nuevoEstado
            };

            return PutAsync(id, data);
        }

        public Task<ApiResult<SightingDTO>> DisableSighting(string id)
        {
            var data = new
            {
                Id = id,
                SightingState = "Eliminado" //type safety fix
            };

            return PutAsync(id, data);
        }

    }
    
}
