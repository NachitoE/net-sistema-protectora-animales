using DTOs;
using Infrastructure.API.Interfaces;
using Microsoft.JSInterop;

public sealed class BlazorDownloadHandler : IDownloadHandler, IAsyncDisposable
{
    private readonly IJSRuntime _js;
    private readonly Lazy<Task<IJSObjectReference>> _module;

    public BlazorDownloadHandler(IJSRuntime js)
    {
        _js = js;
        _module = new(() => _js.InvokeAsync<IJSObjectReference>("import", "/js/download.js").AsTask());
    }

    public async Task TriggerDownloadAsync(DownloadFile file)
    {
        var base64 = Convert.ToBase64String(file.Content);
        var mod = await _module.Value;
        await mod.InvokeVoidAsync("downloadFileFromBytes", file.FileName, file.ContentType, base64);
    }

    public async ValueTask DisposeAsync()
    {
        if (_module.IsValueCreated)
        {
            var mod = await _module.Value;
            await mod.DisposeAsync();
        }
    }
}