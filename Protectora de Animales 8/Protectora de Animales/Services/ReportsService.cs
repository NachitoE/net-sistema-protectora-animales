using DTOs.Reports;
using Infrastructure.Data;
using Domain;
using Helpers;
using Reports;
using System.Text.Json;
using DTOs.Reports.AnimalHistory;
using DTOs;
using System.Diagnostics;

namespace Services
{
    public class ReportsService
    {
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
            List<AnimalDTO> allAnimals = new AnimalsService().GetAll();
            AnimalResponsibleHistoriesService animalRHService = new AnimalResponsibleHistoriesService();
            UsersService userService = new UsersService();
            MedicalCheckUpService medicalCheckUpServ = new MedicalCheckUpService();

            foreach (var animal in allAnimals)
            {
                List<IAnimalHistoryEvent> animalEvents = new();
                //get responsible assigments
                var responsibleAssigments = animalRHService.GetByAnimalId(animal.Id);
                foreach(var assigment in responsibleAssigments)
                {
                    UserDTO? user = userService.Get(assigment.ResponsibleId);
                    if(user == null)
                    {
                        throw new DomainException("Usuario no encontrado al generar el reporte de historial de animales en una asignación de responsable.");
                    }
                    var aRHHandler = new AnimalResponsibleHistoryHandler(user, assigment);
                    animalEvents.Add(aRHHandler);
                }
                //get medical records/check ups
                var medicalCheckUps = medicalCheckUpServ.GetByAnimalId(animal.Id);
                foreach(var medicalRecord in medicalCheckUps)
                {
                    var medicalInfoHandler = new AnimalMedicalInfoHandler(medicalRecord);
                    animalEvents.Add(medicalInfoHandler);
                }
                animalsHistories.Add(CreateAnimalHistoryRowModel(animalEvents, animal));
            }
            dataModel.AnimalHistories = animalsHistories;
            var report = new ReportGenerator(reportFileName: "AnimalHistoryReport");
            string serializedDataModel = JsonSerializer.Serialize(dataModel);
            return report.GenerateReportPDF(serializedDataModel);
        }
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
