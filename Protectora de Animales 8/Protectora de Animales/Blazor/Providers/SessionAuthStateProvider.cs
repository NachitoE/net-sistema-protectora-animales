using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

public sealed class SessionAuthStateProvider : AuthenticationStateProvider
{
    private static readonly ClaimsPrincipal Anon = new(new ClaimsIdentity());
    private readonly SessionService _session;

    public SessionAuthStateProvider(SessionService session)
    {
        _session = session;
        _session.OnChanged += () => NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var principal = _session.IsAuthenticated ? _session.Principal : Anon;
        return Task.FromResult(new AuthenticationState(principal));
    }
}
