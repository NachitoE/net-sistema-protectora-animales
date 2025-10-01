using Microsoft.JSInterop;

namespace Blazor.BlazorServices
{
    public class BlazorTokenStorage
    {
        private IJSInProcessRuntime _js = null;
        private const string TOKEN_ID = "authToken";
        private const string SET_ITEM = "localStorage.setItem";
        private const string GET_ITEM = "localStorage.getItem";
        private const string REMOVE_ITEM = "localStorage.removeItem";
        public BlazorTokenStorage(IJSRuntime js)
        {
            _js = (IJSInProcessRuntime)js;
        }
        public void StoreToken(string token)
        {
            _js.InvokeVoid(SET_ITEM, TOKEN_ID, token);
        }
        public string? GetToken()
        {
            return _js.Invoke<string?>(GET_ITEM, TOKEN_ID);
        }
        public void RemoveToken()
        {
            _js.InvokeVoid(REMOVE_ITEM, TOKEN_ID);
        }
    }
}
