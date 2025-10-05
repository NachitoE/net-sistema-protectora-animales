using DTOs;
using Helpers;
using Services;

namespace WebAPI
{
    public static class SightingEndpoints
    {
        public static void MapSightingEndpoints(this WebApplication app)
        {
            var sightingsService = new SightingsService();

  
            app.MapGet("/sightings/{id}", (string id) =>
            {
                var sighting = sightingsService.Get(id);
                return sighting is not null ? Results.Ok(sighting) : Results.NotFound();
            });

            // GET /sightings
            app.MapGet("/sightings", () =>
            {
                var allSightings = sightingsService.GetAll();
                return Results.Ok(allSightings);
            });

            // POST /sightings
            app.MapPost("/sightings", (SightingRegisterDTO dto) =>
            {
                var created = sightingsService.Add(dto);
                return Results.Created($"/sightings/{created.Id}", created);
            });

            // PUT /sightings/{id}
            app.MapPut("/sightings/{id}", (string id, SightingDTO dto) =>
            {
                if (id != dto.Id) return Results.BadRequest("ID mismatch");
            //Está intentando eliminar, medio hacky esto igual
            if (dto.SightingState == EnumConversion.SightingStateToString(Domain.Sighting.SightingState.Eliminado))
            {
                var disabledBaseResponse = sightingsService.Disable(id);
                return disabledBaseResponse.Success ? Results.Ok(disabledBaseResponse.Sighting) : Results.BadRequest( new { error = disabledBaseResponse.Message} );
                }
                var updated = sightingsService.Update(dto);
                
                return updated is not null ? Results.Ok(updated) : Results.NotFound();
            });

            // DELETE /sightings/{id}
            app.MapDelete("/sightings/{id}", (string id) =>
            {
                var deleted = sightingsService.Delete(id);
                return deleted ? Results.NoContent() : Results.NotFound();
            });
        }
    }
}