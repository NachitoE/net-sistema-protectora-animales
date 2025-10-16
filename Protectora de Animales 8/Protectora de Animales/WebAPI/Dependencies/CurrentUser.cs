﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace WebAPI.Dependencies
{
    public interface ICurrentUser
    {
        bool IsAuthenticated { get; }
        string? UserId { get; }
    }

    public sealed class CurrentUser : ICurrentUser
    {
        private readonly IHttpContextAccessor _accessor;

        public CurrentUser(IHttpContextAccessor accessor) => _accessor = accessor;

        private ClaimsPrincipal? Principal => _accessor.HttpContext?.User;

        public bool IsAuthenticated => Principal?.Identity?.IsAuthenticated == true;

        public string? UserId =>
            Principal?.FindFirst(ClaimTypes.NameIdentifier)?.Value
            ?? Principal?.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;

    }

}
