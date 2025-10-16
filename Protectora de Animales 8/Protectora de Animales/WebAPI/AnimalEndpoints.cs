using Services;
using DTOs;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    public static class AnimalEndpoints
    {
        // To clarify: the 'this' keyword in the parameter defines an extension method for WebApplication.
        // This way you can call MapUserEndpoints from any instance of the WebApplication class.
        public static void MapAnimalEndpoints(this WebApplication app)
        {
            app.MapGet("animals/{id}", (string id) =>
            {
                try
                {
                    AnimalsService animalService = new AnimalsService();
                    AnimalDTO? animalDTO = animalService.Get(id);
                    if (animalDTO == null) throw new ArgumentException("Animal not found");
                    return Results.Ok(animalDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("GetAnimal")
                .Produces<AnimalDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapGet("/animals", () =>
            {
                try
                {
                    AnimalsService animalService = new AnimalsService();
                    List<AnimalDTO> animalDTOs = animalService.GetAll();
                    return Results.Ok(animalDTOs);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("AllAnimals")
                .Produces<IEnumerable<AnimalDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

            app.MapPost("/animals", (AnimalDTO dto) =>
            {
                try
                {
                    AnimalsService animalService = new AnimalsService();
                    AnimalDTO animalDTO = animalService.Add(dto);
                    return Results.Created($"/animal/{animalDTO.Id}", animalDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("AddAnimal")
                .Produces<UserDTO>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapPut("/animals/{id}", (string id, AnimalDTO dto) =>
            {
                try
                {
                    AnimalsService animalService = new AnimalsService();
                    AnimalDTO? animalDTO = animalService.Update(dto);
                    if (animalDTO == null) throw new ArgumentException("No se pudo modificar el animal");
                    return Results.Ok(animalDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("ModifyAnimal")
                .Produces<AnimalDTO>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapDelete("/animals/{id}", (string id) =>
            {
                AnimalsService animalService = new AnimalsService();
                bool deleted = animalService.Delete(id);

                if (deleted)
                    return Results.NoContent();

                return Results.NotFound();
            })
                .WithName("DeleteAnimal")
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound)
                .WithOpenApi();

            app.MapGet("/animals/available", () =>
            {
                try
                {
                    AnimalsService animalService = new AnimalsService();
                    List<AnimalDTO> availableAnimalsDTOs = animalService.GetAvailableAnimals();
                    return Results.Ok(availableAnimalsDTOs);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("AvailableAnimals")
                .Produces<IEnumerable<AnimalDTO>>(StatusCodes.Status200OK)
                .WithOpenApi();

            app.MapPut("/animals/{id}/assign-responsible", (string id, [FromBody] string userId) =>
            {
                try
                {
                    AnimalsService animalService = new AnimalsService();
                    AnimalDTO? assigned = animalService.AssignResponsible(id, userId);
                    return assigned != null ? Results.Ok(assigned) : Results.NotFound();
                }
                catch (DomainException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("Assign Responsible")
                .Produces(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

            app.MapPost("/animals/search", (AnimalDTO criteria) =>
            {
                try
                {
                    AnimalsService animalService = new AnimalsService();
                    List<AnimalDTO> animalsDTOs = animalService.GetByCriteria(criteria);
                    return Results.Ok(animalsDTOs);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
                .WithName("Search Animals")
                .Produces<IEnumerable<AnimalDTO>>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status400BadRequest)
                .WithOpenApi();

        }

    }
}
