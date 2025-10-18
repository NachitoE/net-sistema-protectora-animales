namespace WebAPI
{
    public static class ReportEndpoints
    {
        public static void MapReportEndpoints(this WebApplication app)
        {
            app.MapGet("/reports/adoptions/current-month", () =>
            {
                try
                {
                    var reportsService = new Services.ReportsService();
                    byte[] pdfBytes = reportsService.GenerateCurrentMonthAdoptionReport();
                    return Results.File(pdfBytes, "application/pdf", "AdoptionReport_CurrentMonth.pdf");
                }
                catch(FileNotFoundException ex)
                {
                    return Results.Problem(detail: "Algo pasó en nuestros servidores", statusCode: StatusCodes.Status500InternalServerError);
                }
            })
                .WithName("Download this month adoption report")
                .Produces<byte[]>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status500InternalServerError)
                .WithOpenApi();
        }
    }
}
