using DTOs;
using Services;

namespace WebAPI
{
    public static class AuthEndpoints
    {
        public static void MapAuthEndpoints(this WebApplication app)
        {
            app.MapPost("auth/login", (UserLoginRequestDTO loginReqDTO, JwtService jwtService) =>
            {
                try
                {
                    AuthService authService = new AuthService();
                    UserLoginResponseDTO loginResponse = authService.Login(loginReqDTO);
                    if (loginResponse == null || loginResponse.User == null)
                        throw new ArgumentException("La data del login no es correcta o el usuario no existe");

                    var token = jwtService.GenerateToken(loginResponse.User);
                    return Results.Ok(new UserLoginResponseDTO()
                    {
                        User = loginResponse.User,
                        Token = token
                    });
                }
                catch (ArgumentException ex)
                {
                    return Results.NotFound(new { error = ex.Message });
                }
            })
                .WithName("Login")
                .Produces<UserDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

            app.MapPost("/auth/register", (UserRegisterRequestDTO registerReqDTO) =>
            {
                AuthService authService = new AuthService();
                var result = authService.Register(registerReqDTO);

                if (!result.Success)
                    return Results.BadRequest(new { error = result.Message });

                return Results.Ok(result);
            })
                .WithName("Register")
                .Produces<UserRegisterResponseDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();


            app.MapGet("auth/me", (HttpContext httpContext) =>
            {
                try
                {
                    var userId = httpContext.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                    if (string.IsNullOrEmpty(userId))
                        return Results.Unauthorized();

                    var usersService = new UsersService();
                    var me = usersService.Get(userId);
                    if (me == null)
                        return Results.NotFound(new { error = "Usuario no encontrado" });

                    return Results.Ok(me);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
             .RequireAuthorization()
             .WithName("Me")
             .Produces<UserDTO>(StatusCodes.Status200OK)
             .Produces(StatusCodes.Status401Unauthorized)
             .Produces(StatusCodes.Status404NotFound)
             .WithOpenApi();
        }
    }

}

