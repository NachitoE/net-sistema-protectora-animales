using Blazor.BlazorServices;
using Blazor.Context;
using DTOs;
using Infrastructure.API;
using System.Security.Claims;

public sealed class SessionService
{
    private readonly BlazorTokenStorage _storage;
    private readonly AuthClient _auth = ApiClientsFactory.AuthClient();
    private static readonly ClaimsPrincipal Anon = new(new ClaimsIdentity());

    public bool IsAuthenticated { get; private set; }
    public bool IsLoading { get; private set; }
    public UserDTO? CurrentUser { get; private set; }
    public ClaimsPrincipal Principal { get; private set; } = Anon;

    public event Action? OnChanged;

    public SessionService(BlazorTokenStorage storage)
    {
        _storage = storage;
    }

    public AuthUserContext Context =>
        new(IsAuthenticated, IsLoading, CurrentUser, Principal);

    public async Task HydrateAsync()
    {
        var token = _storage.GetToken();
        if (string.IsNullOrWhiteSpace(token))
        {
            SetAnonymous();
            return;
        }

        TokenBroker.SetToken(token);

        IsLoading = true; Notify();

        var me = await _auth.MeAsync();
        if (!me.Success || me.Data is null)
        {
            _storage.RemoveToken();
            TokenBroker.Clear();
            SetAnonymous();
            return;
        }

        IsAuthenticated = true;
        IsLoading = false;
        CurrentUser = me.Data;
        Principal = new ClaimsPrincipal(new ClaimsIdentity(authenticationType: "jwt"));
        Notify();
    }

    public async Task<bool> LoginAsync(string token)
    {
        _storage.StoreToken(token);
        TokenBroker.SetToken(token);

        IsLoading = true; Notify();

        var me = await _auth.MeAsync();
        if (!me.Success || me.Data is null)
        {
            await LogoutAsync();
            return false;
        }

        IsAuthenticated = true;
        IsLoading = false;
        CurrentUser = me.Data;
        Principal = new ClaimsPrincipal(new ClaimsIdentity(authenticationType: "jwt"));
        Notify();
        return true;
    }

    public Task LogoutAsync()
    {
        _storage.RemoveToken();
        TokenBroker.Clear();
        SetAnonymous();
        return Task.CompletedTask;
    }

    public async Task RefreshUserAsync()
    {
        if (!IsAuthenticated)
        {
            SetAnonymous();
            return;
        }

        IsLoading = true; Notify();
        var me = await _auth.MeAsync();
        if (!me.Success || me.Data is null)
        {
            await LogoutAsync();
            return;
        }

        CurrentUser = me.Data;
        IsLoading = false;
        Notify();
    }

    private void SetAnonymous()
    {
        IsAuthenticated = false;
        IsLoading = false;
        CurrentUser = null;
        Principal = Anon;
        Notify();
    }

    private void Notify() => OnChanged?.Invoke();
}
