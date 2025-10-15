using DTOs;
using Services;

namespace WebAPI
{
    public static class AdoptionEndpoints
    {
        public static void MapAdoptionEndpoints(this WebApplication app)
        {
            app.MapGet("/adoptions", () =>
            {
                var service = new AdoptionsService();
                return Results.Ok(service.GetAll());
            })
            .WithName("Get All Adopciones")
            .Produces<List<AdoptionDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapGet("/adoptions/{id}", (string id) =>
            {
                var service = new AdoptionsService();
                var adoption = service.Get(id);
                if (adoption == null)
                    return Results.NotFound();
                return Results.Ok(adoption);
            })
            .WithName("Get Adopcion por Id")
            .Produces<AdoptionDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPost("/adoptions", (AdoptionRequestDTO dto, JwtService jwtService, HttpContext ctx) =>
            {
                var adoptionServ = new AdoptionsService();
                string? token = jwtService.GetTokenFromRequest(ctx);
                if(token == null)
                    return Results.Unauthorized();
                string? userId = jwtService.GetUserIdFromToken(token);
                if(userId == null)
                    return Results.Unauthorized();

                dto.UserId = userId;
                var created = adoptionServ.Add(dto);
                //TODO: validar que solo sea adoptante

                return Results.Created($"/adoptions/{created.Id}", created);
            })
            .WithName("Crear Adopcion")
            .Produces<AdoptionDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/adoptions/{id}", (string id, AdoptionDTO dto) =>
            {
                //TODO: hacer el catch de que si se está confirmando la adopción que se tome el animal etc, es otro endpoint?
                var service = new AdoptionsService();
                var updated = service.Update(id, dto);
                if (!updated)
                    return Results.NotFound();
                return Results.Ok(dto);
            })
            .WithName("Update Adopcion")
            .Produces<AdoptionDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapDelete("/adoptions/{id}", (string id) =>
            {
                var service = new AdoptionsService();
                var deleted = service.Delete(id);
                if (!deleted)
                    return Results.NotFound();
                return Results.NoContent();
            })
            .WithName("Delete Adopcion")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}