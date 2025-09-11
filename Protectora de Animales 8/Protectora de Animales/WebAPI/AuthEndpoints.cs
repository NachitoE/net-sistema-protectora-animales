using DTOs;
using Services;

namespace WebAPI
{
    public static class AuthEndpoints
    {
        public static void MapAuthEndpoints(this WebApplication app)
        {
            app.MapPost("auth/login", (UserLoginRequestDTO loginReqDTO) =>
            {
                try
                {
                    AuthService authService = new AuthService();
                    UserDTO? userDTO = authService.Login(loginReqDTO);
                    if (userDTO == null) throw new ArgumentException("Login data is incorrect or user does not exist");
                    return Results.Ok(userDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("Login")
                .Produces(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();
        }

    }
}
