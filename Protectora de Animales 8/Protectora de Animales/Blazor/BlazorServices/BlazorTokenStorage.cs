using Microsoft.JSInterop;

namespace Blazor.BlazorServices
{
    public class BlazorTokenStorage
    {
        private IJSRuntime _js = null;
        private const string TOKEN_ID = "authToken";
        private const string SET_ITEM = "localStorage.setItem";
        private const string GET_ITEM = "localStorage.getItem";
        private const string REMOVE_ITEM = "localStorage.removeItem";
        public BlazorTokenStorage(IJSRuntime js)
        {
            _js = js;
        }
        public async Task StoreToken(string token)
        {
            await _js.InvokeVoidAsync(SET_ITEM, TOKEN_ID, token);
        }
        public async Task<string?> GetToken()
        {
            return await _js.InvokeAsync<string?>(GET_ITEM, TOKEN_ID);
        }
        public async Task RemoveToken()
        {
            await _js.InvokeVoidAsync(REMOVE_ITEM, TOKEN_ID);
        }
    }
}
