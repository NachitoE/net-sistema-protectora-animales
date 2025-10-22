using DTOs;
using Services;

namespace WebAPI
{
    public static class MedicalCheckUpEndpoints
    {
        public static void MapMedicalCheckUpEndpoints(this WebApplication app)
        {
            var checkUpsGroup = app.MapGroup("/medical-checkups")
                .WithTags("Medical CheckUps")
                .WithOpenApi();

            checkUpsGroup.MapGet("/", () =>
            {
                MedicalCheckUpService checkUpService = new MedicalCheckUpService();
                List<MedicalCheckUpDTO> checkUps = checkUpService.GetAll();
                return Results.Ok(checkUps);
            })
            .WithName("GetAllMedicalCheckUps")
            .WithSummary("Obtener todos los controles médicos")
            .WithDescription("Devuelve la lista completa de controles médicos registrados")
            .Produces<List<MedicalCheckUpDTO>>(StatusCodes.Status200OK);

            checkUpsGroup.MapGet("/{id}", (string id) =>
            {
                try
                {
                    MedicalCheckUpService checkUpService = new MedicalCheckUpService();
                    MedicalCheckUpDTO? checkUpDTO = checkUpService.Get(id);
                    if (checkUpDTO == null) throw new ArgumentException("Control médico no encontrado");
                    return Results.Ok(checkUpDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("GetMedicalCheckUpById")
            .WithSummary("Obtener un control médico por ID")
            .WithDescription("Devuelve los detalles de un control médico específico")
            .Produces<MedicalCheckUpDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);

            checkUpsGroup.MapPut("/{id}", (string id, MedicalCheckUpDTO dto) =>
            {
                try
                {
                    MedicalCheckUpService checkUpService = new MedicalCheckUpService();
                    MedicalCheckUpDTO? checkUpDTO = checkUpService.Update(id, dto);
                    if (checkUpDTO == null) throw new ArgumentException("No se pudo modificar el control médico");
                    return Results.Ok(checkUpDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("UpdateMedicalCheckUp")
            .WithSummary("Actualizar un control médico")
            .WithDescription("Modifica los datos de un control médico existente")
            .Produces<MedicalCheckUpDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);

            checkUpsGroup.MapPost("/", (MedicalCheckUpRegisterDTO checkUpRegDTO) =>
            {
                try
                {
                    MedicalCheckUpService checkUpService = new MedicalCheckUpService();
                    MedicalCheckUpDTO checkUpDTO = checkUpService.Add(checkUpRegDTO);
                    return Results.Created($"/medical-checkups/{checkUpDTO.Id}", checkUpDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("CreateMedicalCheckUp")
            .WithSummary("Registrar un nuevo control médico")
            .WithDescription("Crea un nuevo registro de control médico para un animal")
            .Produces<MedicalCheckUpDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

            checkUpsGroup.MapGet("/animal/{animalId}", (string animalId) =>
            {
                try
                {
                    MedicalCheckUpService checkUpService = new MedicalCheckUpService();
                    var checkUps = checkUpService.GetByAnimalId(animalId);
                    if (checkUps == null || checkUps.Count == 0)
                    {
                        throw new ArgumentException("No se encontraron controles médicos para este animal");
                    }
                    return Results.Ok(checkUps);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("GetMedicalCheckUpsByAnimal")
            .WithSummary("Obtener controles médicos por animal")
            .WithDescription("Devuelve todos los controles médicos realizados a un animal específico")
            .Produces<List<MedicalCheckUpDTO>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);

            checkUpsGroup.MapDelete("/{id}", (string id) =>
            {
                try
                {
                    MedicalCheckUpService checkUpService = new MedicalCheckUpService();
                    bool deleted = checkUpService.Delete(id);
                    if (deleted)
                        return Results.NoContent();
                    return Results.NotFound();
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("DeleteMedicalCheckUp")
            .WithSummary("Eliminar un control médico")
            .WithDescription("Elimina un control médico del sistema")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest);
        }
    }
}