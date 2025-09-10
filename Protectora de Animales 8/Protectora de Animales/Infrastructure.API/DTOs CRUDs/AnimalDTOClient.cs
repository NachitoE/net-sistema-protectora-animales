using DTOs;

namespace Infrastructure.API
{
    public class AnimalDTOClient : BaseDTOClient<AnimalDTO>
    {
        protected override string _endpoint => "animals";
        public AnimalDTOClient(IApiHttpClient apiHttpClient) : base(apiHttpClient)
        {
        }
    }
}
