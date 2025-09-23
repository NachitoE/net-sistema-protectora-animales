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

            app.MapPost("/auth/register", (UserRegisterRequestDTO registerReqDTO) =>
            {
                AuthService authService = new AuthService();
                var result = authService.Register(registerReqDTO); // devuelve UserRegisterResponseDTO

                if (!result.Success)
                    return Results.BadRequest(result);

                return Results.Ok(result);
            })
   .WithName("Register")
   .Produces<UserRegisterResponseDTO>(StatusCodes.Status200OK)
   .Produces<UserRegisterResponseDTO>(StatusCodes.Status400BadRequest)
   .WithOpenApi();
        }

    }
}
