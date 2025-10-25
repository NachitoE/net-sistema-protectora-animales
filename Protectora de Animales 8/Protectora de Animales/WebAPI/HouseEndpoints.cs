using DTOs;
using DTOs.House;
using Services;
using WebAPI.Dependencies;
namespace WebAPI
{
    public static class HouseEndpoints
    {
        public static void MapHouseEndpoints(this WebApplication app)
        {
            app.MapGet("/houses", () =>
            {
                HousesService housesService = new HousesService();
                List<HouseDTO> houses = housesService.GetAll();
                return Results.Ok(houses);
            })
                .WithName("Get All Houses")
                .Produces<List<HouseDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

            app.MapGet("/houses/{id}", (string id) =>
            {
                try
                {
                    HousesService housesService = new HousesService();
                    HouseDTO? houseDTO = housesService.Get(id);
                    if (houseDTO == null) throw new ArgumentException("Casa no encontrada");
                    return Results.Ok(houseDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("Get House By Id")
                .Produces<HouseDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapPut("/houses/{id}", (string id, HouseDTO dto) =>
            {
                try
                {
                    HousesService houseService  = new HousesService();
                    HouseDTO? houseDTO = houseService.Modify(id, dto);
                    if (houseDTO == null) throw new ArgumentException("No se pudo modificar el usuario");
                    return Results.Ok(houseDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .RequireAuthorization("AdminOnly")
                .WithName("Update House")
                .Produces<HouseDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapPut("/houses/capacity", (HouseChangeCapacityDTO houseCapDTO) =>
                {
                    try
                    {
                        HousesService housesService = new HousesService();
                        HouseBaseResponseDTO houseResponseDTO = housesService.ChangeCapacity(houseCapDTO);
                        if (!houseResponseDTO.Success) throw new ArgumentException(houseResponseDTO.Message);
                        return Results.Ok(housesService.Get(houseResponseDTO.HouseId));
                    }
                    catch (ArgumentException ex)
                    {
                        return Results.BadRequest(new { error = ex.Message });
                    }
                })
                    .WithName("Update House Capacity")
                    .Produces<HouseDTO>(StatusCodes.Status200OK)
                    .Produces(StatusCodes.Status400BadRequest)
                    .WithOpenApi();

            app.MapPost("/houses", (HouseRegisterRequestDTO houseRegDTO) =>
            {
                try
                {
                    HousesService housesService = new HousesService();
                    // un usuario puede tener solo 1 casa asignada
                    if (housesService.HasHouse(houseRegDTO.UserId))
                    {
                        throw new ArgumentException("El usuario ya tiene una casa asignada");
                    }
                    HouseDTO houseDTO = housesService.Add(houseRegDTO);
                    return Results.Created($"/houses/{houseDTO.Id}", houseDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("Register House")
                .Produces<HouseDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapGet("/houses/user-house/{userId}", (string userId) =>
            {
                try
                {
                    HousesService housesService = new HousesService();
                    // un usuario puede tener solo 1 casa asignada
                    var house = housesService.GetHouseBelongingToUser(userId);
                    if (house == null)
                    {
                        throw new ArgumentException("El usuario no tiene una casa asignada");
                    }
                    return Results.Ok(house);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("Get House by userid")
                .Produces<HouseDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapDelete("/houses/{id}", (string id) =>
            {
                try
                {
                    HousesService housesService = new HousesService();
                    bool deleted = housesService.Delete(id);
                    return Results.NoContent();
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .RequireAuthorization("AdminOnly")
                .WithName("Delete House")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

                app.MapPut("/houses/change-address", (HouseChangeAddressDTO changeAddressDTO, ICurrentUser currentUser) =>
                {
                    try
                    {
                        if (currentUser.UserId == null)
                            throw new ArgumentException("Usuario no autenticado");
                        UsersService usersService= new UsersService();
                        var userDTO = usersService.Get(currentUser.UserId);
                        if (userDTO == null)
                            throw new ArgumentException("Usuario no encontrado");
                        if(userDTO.Id != currentUser.UserId && userDTO.UserType != "Admin")
                            throw new ArgumentException("No puede cambiar la dirección de otra persona");
                        HousesService housesService = new HousesService();

                        HouseBaseResponseDTO houseResponseDTO = housesService.ChangeAddress(changeAddressDTO);
                        if (!houseResponseDTO.Success)
                            throw new ArgumentException(houseResponseDTO.Message);
                        return Results.Ok(housesService.Get(houseResponseDTO.HouseId));
                    }
                    catch (ArgumentException ex)
                    {
                        return Results.BadRequest(new { error = ex.Message });
                    }
                })
                .RequireAuthorization()
                .WithName("Cambiar direccíón de hogar del usuario de tránsito loggeado (TAMBIEN ACCESIBLE X ADMIN)")
                .Produces<HouseDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();
        }

    }
}
