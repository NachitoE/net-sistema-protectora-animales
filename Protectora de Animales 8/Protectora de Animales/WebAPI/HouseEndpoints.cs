using DTOs;
using DTOs.House;
using Services;
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
                .Produces<UserDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();
        }
    }
}
