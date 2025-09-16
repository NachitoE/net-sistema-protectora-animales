
using Infrastructure.API;

namespace Infrastructure.API
{
    public abstract class BaseDTOClient<TResponse> 
        where TResponse : class 
    {
        protected abstract string _endpoint { get; }
        protected IApiHttpClient _apiHttpClient;
        public BaseDTOClient(IApiHttpClient apiHttpClient)
        {
            _apiHttpClient = apiHttpClient;
        }

        public async virtual Task<TResponse> GetAsync(string id) => await _apiHttpClient.GetAsync<TResponse>($"{_endpoint}/{id}");
        public async virtual Task<TResponse> GetAllAsync() => await _apiHttpClient.GetAsync<TResponse>($"{_endpoint}/");
        public async virtual Task<TResponse> PostAsync(object data) => await _apiHttpClient.PostAsync<TResponse>($"{_endpoint}", data);
        public async virtual Task<TResponse> PutAsync(string id, object data) => await _apiHttpClient.PutAsync<TResponse>($"{_endpoint}/{id}", data);
        public async virtual Task<bool> DeleteAsync(string id) => await _apiHttpClient.DeleteAsync($"{_endpoint}/{id}");

    }
}
