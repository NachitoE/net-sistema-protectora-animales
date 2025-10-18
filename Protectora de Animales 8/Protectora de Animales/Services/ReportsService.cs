using DTOs.Reports;
using Infrastructure.Data;
using Domain;
using Helpers;
using Reports;
using System.Text.Json;

namespace Services
{
    public class ReportsService
    {
        public byte[] GenerateCurrentMonthAdoptionReport()
        {
            int currMonth = DateTime.Now.Month;
            string currMonthStr = currMonth.ToString("MMMM");
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
    }
}
