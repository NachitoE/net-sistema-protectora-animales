using DTOs;
using DTOs.Adoption;
using Services;
using WebAPI.Dependencies;

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

            app.MapPost("/adoptions", (AdoptionRequestDTO dto, ICurrentUser currentUser) =>
            {
                var adoptionServ = new AdoptionsService();
                string? userId = currentUser.UserId;
                if (userId == null)
                    return Results.Unauthorized();

                dto.UserId = userId;
                var created = adoptionServ.Add(dto);
                //TODO: validar que solo sea adoptante

                return Results.Created($"/adoptions/{created.Id}", created);
            })
            .RequireAuthorization("AdopterOrAdminOnly")
            .WithName("Crear Adopcion")
            .Produces<AdoptionDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/adoptions/{id}", (string id, AdoptionDTO dto) =>
            {
                var service = new AdoptionsService();
                var updated = service.Update(id, dto);
                if (!updated)
                    return Results.NotFound();
                return Results.Ok(dto);
            })
            .RequireAuthorization("AdminOnly")
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

            app.MapPut("/adoptions/{id}/approve-reject", (string id, AdoptionRejectApproveDTO dto) =>
            {
                var service = new AdoptionsService();
                try
                {
                    var updatedDTO = service.ApproveOrRejectPendingAdoption(id, dto);
                    if (updatedDTO == null)
                        return Results.NotFound();
                    return Results.Ok(dto);
                }
                catch (NotFoundException ex)
                {
                    return Results.NotFound(new { error = ex.Message });
                }
                catch (DomainException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .RequireAuthorization("FosterOrVolunteerOrAdminOnly")
            .WithName("Rechazar o aprobar Adopcion")
            .Produces<AdoptionDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapGet("/adoptions/my-adoptions", (ICurrentUser CurrentUser) =>
            {
                var userId = CurrentUser.UserId;
                if (userId == null)
                    return Results.Unauthorized();
                var service = new AdoptionsService();
                var adoptions = service.GetAdoptionsByUserId(userId);
                return Results.Ok(adoptions);
            }
            )
            .RequireAuthorization("AdopterOnly")
            .WithName("Get Mis Adopciones")
            .Produces<List<AdoptionDTO>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status401Unauthorized)
            .WithOpenApi();

        }
    }
}