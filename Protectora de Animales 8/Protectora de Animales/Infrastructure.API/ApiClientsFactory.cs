using Infrastructure.API.DTOs_CRUDs;
using Infrastructure.API.Interfaces;
using Infrastructure.API.Other;

namespace Infrastructure.API
{
    public static class ApiClientsFactory
    {
        private const string BASE_URL = "https://localhost:7056/";
        public static UserDTOClient UserClient() => new UserDTOClient(new APIHttpClient(BASE_URL));
        public static AnimalDTOClient AnimalClient() => new AnimalDTOClient(new APIHttpClient(BASE_URL));
        public static HouseDTOClient HouseClient() => new HouseDTOClient(new APIHttpClient(BASE_URL));
        public static SightingDTOClient SightingClient() => new SightingDTOClient(new APIHttpClient(BASE_URL));
        public static AdoptionDTOClient AdoptionClient() => new AdoptionDTOClient(new APIHttpClient(BASE_URL));
        public static MedicalCheckUpDTOClient MedicalCheckUpClient() => new MedicalCheckUpDTOClient(new APIHttpClient(BASE_URL));
        public static AuthClient AuthClient() => new AuthClient(new APIHttpClient(BASE_URL));
        public static ReportClient ReportClient(IDownloadHandler downloadHandler) => new ReportClient(new APIHttpClient(BASE_URL), downloadHandler);


    }
}
