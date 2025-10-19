using DTOs;

namespace Infrastructure.API
{
    public interface IApiHttpClient
    {
        Task<ApiResult<T>> GetAsync<T>(string endpoint);
        Task<ApiResult<T>> PostAsync<T>(string endpoint, object data);
        Task<ApiResult<T>> PutAsync<T>(string endpoint, object data);
        Task<ApiResult<bool>> DeleteAsync(string endpoint);
        Task<ApiResult<DownloadFile>> DownloadAsync(string endpoint);

    }
}