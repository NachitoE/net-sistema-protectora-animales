using DTOs;


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
