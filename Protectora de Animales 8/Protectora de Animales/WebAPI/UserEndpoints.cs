using Services;
using DTOs;
using Microsoft.IdentityModel.Tokens;

namespace WebAPI
{
    public static class UserEndpoints
    {
        // To clarify: the 'this' keyword in the parameter defines an extension method for WebApplication.
        // This way you can call MapUserEndpoints from any instance of the WebApplication class.
        public static void MapUserEndpoints(this WebApplication app)
        {
            app.MapGet("/users/{id}", (string id) =>
            {
                try
                {
                    UsersService userService = new UsersService();
                    UserDTO? userDTO = userService.Get(id);
                    if (userDTO == null) throw new ArgumentException("User not found");
                    return Results.Ok(userDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("GetUser")
                .Produces<UserDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapGet("/users", (string? userName) =>
            {
                try
                {
                    UsersService userService = new UsersService();
                    List<UserDTO> usersDTOs = userService.GetAll();
                    return Results.Ok(usersDTOs);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("AllUsers")
                .Produces<IEnumerable<UserDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

            app.MapPost("/users", (UserDTO dto) =>
            {
                try
                {
                    UsersService userService = new UsersService();
                    UserDTO userDTO = userService.Add(dto);
                    return Results.Created($"/users/{userDTO.Id}", userDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("AddUser")
                .Produces<UserDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapDelete("/users/{id}", (string id) =>
            {
                UsersService userService = new UsersService();
                bool deleted = userService.Delete(id);

                if (deleted)
                    return Results.NoContent();

                return Results.NotFound();
            })
                .WithName("DeleteUser")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

            app.MapPost("/users/search", (UserDTO criteria) =>
            {
                try
                {
                    UsersService userService = new UsersService();
                    List<UserDTO> usersDTOs = userService.GetByCriteria(criteria);
                    return Results.Ok(usersDTOs);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("SearchUsers")
                .Produces<IEnumerable<UserDTO>>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapGet("/users/available-to-adopt", () =>
            {
                try
                {
                    UsersService userService = new UsersService();
                    List<UserDTO> userDTOs = userService.GetAvailableToAdopt();
                    if (userDTOs == null) throw new ArgumentException("No available users found");
                    return Results.Ok(userDTOs);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("AvailableToAdopt")
                .Produces<UserDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();
        }
    }
}
