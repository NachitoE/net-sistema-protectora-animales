using DTOs;
using Infrastructure.API.Interfaces;

namespace Infrastructure.API.Other
{
    public class ReportClient
    {
        private readonly string _endpoint = "reports";
        protected IApiHttpClient _apiHttpClient;
        private readonly IDownloadHandler _downloadHandler;
        public ReportClient(IApiHttpClient apiHttpClient, IDownloadHandler downloadHandler)
        {
            _apiHttpClient = apiHttpClient;
            _downloadHandler = downloadHandler;
        }

        public async Task<ApiResult<DownloadFile>> DownloadAdoptionMonthReportAsync() { 

            return await HandleDownloadReportAsync($"/{_endpoint}/adoptions/current-month");
        }
        public async Task<ApiResult<DownloadFile>> DownloadAnimalsHistory()
        {

            return await HandleDownloadReportAsync($"/{_endpoint}/animals/history");
        }
        private async Task<ApiResult<DownloadFile>> HandleDownloadReportAsync(string finalEndpoint)
        {
            var result = await _apiHttpClient.DownloadAsync(finalEndpoint);
            if (result.Success && result.Data != null)
            {
                await _downloadHandler.TriggerDownloadAsync(result.Data);
            }
            return result;
        }
    }
}
