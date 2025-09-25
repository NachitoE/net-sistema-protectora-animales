using DTOs;
using DTOs.House;
using Services;
namespace WebAPI
{
    public static class HouseEndpoints
    {
        public static void MapHouseEndpoints(this WebApplication app)
        {
            app.MapPost("/houses", (HouseRegisterRequestDTO houseRegDTO) =>
            {
                try
                {
                    HousesService housesService = new HousesService();
                    // un usuario puede tener solo 1 casa asignada
                    if (housesService.HasHouse(houseRegDTO.UserId))
                    {
                        throw new ArgumentException("The user already has a registered house");
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
