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
                    UserLoginResponseDTO loginResponse = authService.Login(loginReqDTO);
                    if (loginResponse == null || loginResponse.User == null)
                        throw new ArgumentException("Login data is incorrect or user does not exist");
                    return Results.Ok(loginResponse);
                }
                catch (ArgumentException ex)
                {
                    return Results.NotFound(new UserLoginResponseDTO()
                    {
                        User = null,
                        Message = ex.Message,
                        Success = false
                    });
                }
            })
                .WithName("Login")
                .Produces(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

            app.MapPost("auth/register", (UserRegisterRequestDTO registerReqDTO) =>
            {
                try
                {
                    AuthService authService = new AuthService();
                    bool registered = authService.Register(registerReqDTO);
                    if (!registered) throw new ArgumentException("Username already exists");
                    return Results.Ok(new UserRegisterResponseDTO()
                    {
                        Message = "User registered successfully",
                        Success = true
                    });
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new UserRegisterResponseDTO()
                    {
                        Message = ex.Message,
                        Success = false
                    });
                }
            })
                .WithName("Register")
                .Produces(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();
        }

    }
}
