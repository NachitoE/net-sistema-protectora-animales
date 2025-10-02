using DTOs;
using System.Security.Claims;

namespace Blazor.Context
{
    public sealed record AuthUserContext(
        bool IsAuthenticated,
        bool IsLoading,
        UserDTO? User,
        ClaimsPrincipal Principal
    );
}
