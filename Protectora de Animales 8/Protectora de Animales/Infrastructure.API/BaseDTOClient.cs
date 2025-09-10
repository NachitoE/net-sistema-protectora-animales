
using Infrastructure.API.Interfaces;

namespace Infrastructure.API
{
    public abstract class BaseDTOClient<T> where T : class 
    {
        protected string _endpoint = "";
        IApiHttpClient _apiHttpClient;
        public BaseDTOClient(IApiHttpClient apiHttpClient)
        {
            _apiHttpClient = apiHttpClient;
        }

        public async virtual Task<T> GetAsync(string id) => await _apiHttpClient.GetAsync<T>($"{_endpoint}/{id}");
        public async virtual Task<T> PostAsync(string id, object data) => await _apiHttpClient.PostAsync<T>($"{_endpoint}/{id}", data);
        public async virtual Task<T> PutAsync(string id, object data) => await _apiHttpClient.PutAsync<T>($"{_endpoint}/{id}", data);
        public async virtual Task<bool> DeleteAsync(string id) => await _apiHttpClient.DeleteAsync($"{_endpoint}/{id}");

    }
}
