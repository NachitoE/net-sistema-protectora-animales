using Services;
using DTOs;

namespace WebAPI
{
    public static class UserEndpoints
    {
        // To clarify: the 'this' keyword in the parameter defines an extension method for WebApplication.
        // This way you can call MapUserEndpoints from any instance of the WebApplication class.
        public static void MapUserEndpoints(this WebApplication app)
        {
            app.MapPost("/users/login", (UserLoginRequestDTO loginRequest) =>
            {
                try
                {
                    var authService = new AuthService();
                    var response = authService.Login(loginRequest);

                    if (response.Success && response.User != null)
                    {
                        return Results.Ok(response);
                    }

                    return Results.BadRequest(new { error = response.Message ?? "Credenciales inválidas" });
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            })
                .WithName("LoginUser")
                .Produces<UserLoginResponseDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();
            
            app.MapGet("/users/{id}", (string id) =>
            {
                try
                {
                    UsersService userService = new UsersService();
                    UserDTO? userDTO = userService.Get(id);
                    if (userDTO == null) throw new ArgumentException("Usuario no encontrado");
                    return Results.Ok(userDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("papasconmilanesa")
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
            /*
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
            */
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
                    if (!(userDTOs.Count > 0)) throw new ArgumentException("No hay usuarios disponibles para adoptar");
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

            app.MapGet("/users/{id}/animals", (string id) =>
            {
                try
                {
                    AnimalsService animalService = new AnimalsService();
                    List<AnimalDTO> animalsDTO = animalService.GetAnimalsBelongingToUser(id);
                    if (!(animalsDTO.Count > 0)) throw new ArgumentException("El usuario no cuenta con animales asignados");
                    return Results.Ok(animalsDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("Conseguir animales del usuario")
                .Produces<AnimalDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapGet("/users/{id}/remaining-capacity", (string id) =>
            {
                try
                {
                    UsersService usersService = new UsersService();
                    var response = usersService.GetUserRemainingCapacity(id);
                    if(!response.Success) throw new ArgumentException(response.Message ?? "No se pudo obtener la capacidad restante del usuario");
                    return Results.Ok(response)
;                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("Conseguir cuantos animales puede almacenar el usuario")
                .Produces<AnimalDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapPut("/users/{id}", (string id, UserDTO dto) =>
            {
                try
                {
                    UsersService userService = new UsersService();
                    UserDTO? userDTO = userService.ModifyUser(id, dto);
                    if (userDTO == null) throw new ArgumentException("No se pudo modificar el usuario");
                    return Results.Ok(userDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .RequireAuthorization("AdminOnly")
                .WithName("UpdateUser")
                .Produces<UserDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();
        }

    }
}
