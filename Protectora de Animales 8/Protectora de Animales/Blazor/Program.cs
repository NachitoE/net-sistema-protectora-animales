using Blazor;
using Blazor.BlazorServices;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// core session services
builder.Services.AddScoped<BlazorTokenStorage>();
builder.Services.AddScoped<SessionService>();

// Provider para AuthorizeView y [Authorize]
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, SessionAuthStateProvider>();

await builder.Build().RunAsync();
