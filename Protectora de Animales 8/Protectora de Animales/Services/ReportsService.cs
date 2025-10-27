using DTOs.Reports;
using Infrastructure.Data;
using Domain;
using Helpers;
using Reports;
using System.Text.Json;
using DTOs.Reports.AnimalHistory;
using DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using DTOs.History;

namespace Services
{
    public class ReportsService
    {
        private readonly string _connectionString;

        public ReportsService()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found in configuration.");
        }

        public byte[] GenerateCurrentMonthAdoptionReport()
        {
            DateTime now = DateTime.Now;
            int currMonth = now.Month;
            string currMonthStr = now.ToString("MMMM");
            AdoptionDataModel dataModel = new AdoptionDataModel()
            {
                Header = $"Reporte de solicitudes de Adopción - {currMonthStr}",
                Footer = "Generado por el sistema Protectora ATUEL"
            };
            AdoptionRepository adoptionRepository = new AdoptionRepository();
            List<AdoptionRowModel> adoptions = adoptionRepository
                .GetAll()
                .Where(x => x.AdoptionRequestDate.Month == currMonth)
                .Select(x => CreateAdoptionRowModel(x))
                .ToList();

            dataModel.Adoptions = adoptions;

            var report = new ReportGenerator(reportFileName: "AdoptionReport");
            string serializedDataModel = JsonSerializer.Serialize(dataModel);
            return report.GenerateReportPDF(serializedDataModel);
        }

        public byte[] GenerateAnimalsHistoryReport()
        {
            AnimalHistoryDataModel dataModel = new AnimalHistoryDataModel()
            {
                Header = $"Historial de animales",
                Footer = "Generado por el sistema Protectora ATUEL",
            };

            List<AnimalHistoryRowModel> animalsHistories = new();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var responsibleHistories = GetAllResponsibleHistoriesWithDetails(connection);

                var medicalCheckUps = GetAllMedicalCheckUpsWithDetails(connection);

                var animalIds = responsibleHistories.Select(h => h.AnimalId)
                    .Union(medicalCheckUps.Select(m => m.AnimalId))
                    .Distinct()
                    .OrderBy(id => id)
                    .ToList();
                if (!animalIds.Any())
                {
                    animalIds = GetAllAnimalIds(connection);
                }

                foreach (var animalId in animalIds)
                {
                    List<IAnimalHistoryEvent> animalEvents = new();
                    var animalResponsibleHistories = responsibleHistories
                        .Where(h => h.AnimalId == animalId)
                        .ToList();

                    foreach (var history in animalResponsibleHistories)
                    {
                        var aRHHandler = new AnimalResponsibleHistoryHandler(
                            history.ResponsibleUser,
                            history.HistoryData
                        );
                        animalEvents.Add(aRHHandler);
                    }

                    var animalMedicalCheckUps = medicalCheckUps
                        .Where(m => m.AnimalId == animalId)
                        .ToList();

                    foreach (var checkUp in animalMedicalCheckUps)
                    {
                        var medicalInfoHandler = new AnimalMedicalInfoHandler(checkUp.CheckUpData);
                        animalEvents.Add(medicalInfoHandler);
                    }
                    var animalInfo = animalResponsibleHistories.FirstOrDefault()?.AnimalData
                        ?? animalMedicalCheckUps.FirstOrDefault()?.AnimalData;

                    if (animalInfo != null)
                    {
                        animalsHistories.Add(CreateAnimalHistoryRowModel(animalEvents, animalInfo));
                    }
                }
            }

            dataModel.AnimalHistories = animalsHistories;
            var report = new ReportGenerator(reportFileName: "AnimalHistoryReport");
            string serializedDataModel = JsonSerializer.Serialize(dataModel);
            return report.GenerateReportPDF(serializedDataModel);
        }

        #region ADO.NET Private Methods

        private List<ResponsibleHistoryWithDetails> GetAllResponsibleHistoriesWithDetails(SqlConnection connection)
        {
            var results = new List<ResponsibleHistoryWithDetails>();

            string query = @"
                SELECT 
                    arh.Id AS HistoryId,
                    arh.AssignedDate,
                    arh.ResponsibleId,
                    arh.AnimalId,
                    u.Id AS UserId,
                    u.Name AS UserName,
                    u.SurName AS UserSurName,
                    u.Dni AS UserDni,
                    u.UserType,
                    u.UserName AS UserUsername,
                    u.UserStatus,
                    a.Id AS AnimalId,
                    a.Name AS AnimalName,
                    a.Species AS AnimalSpecies,
                    a.BirthDate AS AnimalBirthDate,
                    a.UserId AS AnimalUserId,
                    a.AnimalState,
                    a.Description AS AnimalDescription
                FROM AnimalResponsibleHistories arh
                INNER JOIN Users u ON arh.ResponsibleId = u.Id
                INNER JOIN Animals a ON arh.AnimalId = a.Id
                ORDER BY a.Id, arh.AssignedDate";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    results.Add(new ResponsibleHistoryWithDetails
                    {
                        AnimalId = reader.GetString(reader.GetOrdinal("AnimalId")),
                        HistoryData = new AnimalResponsibleHistoryDTO
                        {
                            Id = reader.GetString(reader.GetOrdinal("HistoryId")),
                            AssignedDate = reader.GetDateTime(reader.GetOrdinal("AssignedDate")),
                            ResponsibleId = reader.GetString(reader.GetOrdinal("ResponsibleId")),
                            AnimalId = reader.GetString(reader.GetOrdinal("AnimalId"))
                        },
                        ResponsibleUser = new UserDTO
                        {
                            Id = reader.GetString(reader.GetOrdinal("UserId")),
                            Name = reader.GetString(reader.GetOrdinal("UserName")),
                            SurName = reader.GetString(reader.GetOrdinal("UserSurName")),
                            DNI = reader.GetString(reader.GetOrdinal("UserDni")),
                            UserType = reader.GetString(reader.GetOrdinal("UserType")),
                            UserName = reader.GetString(reader.GetOrdinal("UserUsername")),
                        },
                        AnimalData = new AnimalDTO
                        {
                            Id = reader.GetString(reader.GetOrdinal("AnimalId")),
                            Name = reader.GetString(reader.GetOrdinal("AnimalName")),
                            Species = reader.GetString(reader.GetOrdinal("AnimalSpecies")),
                            BirthDate = reader.GetDateTime(reader.GetOrdinal("AnimalBirthDate")),
                            UserId = reader.IsDBNull(reader.GetOrdinal("AnimalUserId"))
                                ? string.Empty
                                : reader.GetString(reader.GetOrdinal("AnimalUserId")),
                            AnimalState = reader.GetString(reader.GetOrdinal("AnimalState")),
                            Description = reader.GetString(reader.GetOrdinal("AnimalDescription"))
                        }
                    });
                }
            }

            return results;
        }

        private List<MedicalCheckUpWithDetails> GetAllMedicalCheckUpsWithDetails(SqlConnection connection)
        {
            var results = new List<MedicalCheckUpWithDetails>();

            string query = @"
                SELECT 
                    mc.Id AS CheckUpId,
                    mc.CheckUpDate,
                    mc.Observation,
                    mc.AnimalId,
                    a.Id AS AnimalId,
                    a.Name AS AnimalName,
                    a.Species AS AnimalSpecies,
                    a.BirthDate AS AnimalBirthDate,
                    a.UserId AS AnimalUserId,
                    a.AnimalState,
                    a.Description AS AnimalDescription
                FROM MedicalCheckUps mc
                INNER JOIN Animals a ON mc.AnimalId = a.Id
                ORDER BY a.Id, mc.CheckUpDate";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    results.Add(new MedicalCheckUpWithDetails
                    {
                        AnimalId = reader.GetString(reader.GetOrdinal("AnimalId")),
                        CheckUpData = new MedicalCheckUpDTO
                        {
                            Id = reader.GetString(reader.GetOrdinal("CheckUpId")),
                            CheckUpDate = reader.GetDateTime(reader.GetOrdinal("CheckUpDate")),
                            Observation = reader.GetString(reader.GetOrdinal("Observation")),
                            AnimalId = reader.GetString(reader.GetOrdinal("AnimalId"))
                        },
                        AnimalData = new AnimalDTO
                        {
                            Id = reader.GetString(reader.GetOrdinal("AnimalId")),
                            Name = reader.GetString(reader.GetOrdinal("AnimalName")),
                            Species = reader.GetString(reader.GetOrdinal("AnimalSpecies")),
                            BirthDate = reader.GetDateTime(reader.GetOrdinal("AnimalBirthDate")),
                            UserId = reader.IsDBNull(reader.GetOrdinal("AnimalUserId"))
                                ? string.Empty
                                : reader.GetString(reader.GetOrdinal("AnimalUserId")),
                            AnimalState = reader.GetString(reader.GetOrdinal("AnimalState")),
                            Description = reader.GetString(reader.GetOrdinal("AnimalDescription"))
                        }
                    });
                }
            }

            return results;
        }
        private List<string> GetAllAnimalIds(SqlConnection connection)
        {
            var animalIds = new List<string>();
            string query = "SELECT Id FROM Animals ORDER BY Id";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    animalIds.Add(reader.GetString(0));
                }
            }

            return animalIds;
        }

        #endregion

        #region Helper Classes

        private class ResponsibleHistoryWithDetails
        {
            public string AnimalId { get; set; }
            public AnimalResponsibleHistoryDTO HistoryData { get; set; }
            public UserDTO ResponsibleUser { get; set; }
            public AnimalDTO AnimalData { get; set; }
        }

        private class MedicalCheckUpWithDetails
        {
            public string AnimalId { get; set; }
            public MedicalCheckUpDTO CheckUpData { get; set; }
            public AnimalDTO AnimalData { get; set; }
        }

        #endregion

        private AdoptionRowModel CreateAdoptionRowModel(Adoption adoption)
        {
            return new AdoptionRowModel()
            {
                AnimalName = adoption.Animal.Name,
                AdopterUserName = adoption.User.UserName,
                AdoptionRequestDate = adoption.AdoptionRequestDate.ToString("dd/MM/yyyy"),
                AdoptionResponseDate = adoption.AdoptionResponseDate.HasValue ? adoption.AdoptionResponseDate.Value.ToString("dd/MM/yyyy") : null,
                State = EnumConversion.AdoptionStateToString(adoption.State),
                Description = adoption.Description
            };
        }

        private AnimalHistoryRowModel CreateAnimalHistoryRowModel(List<IAnimalHistoryEvent> events, AnimalDTO animal)
        {
            return new AnimalHistoryRowModel()
            {
                AnimalName = animal.Name,
                Events = events
            };
        }
    }
}
