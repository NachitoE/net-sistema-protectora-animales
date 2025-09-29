using DTOs.Sighting;


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
    }
    
}
