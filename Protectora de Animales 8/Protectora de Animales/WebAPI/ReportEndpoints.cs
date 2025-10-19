namespace WebAPI
{
    public static class ReportEndpoints
    {
        public static void MapReportEndpoints(this WebApplication app)
        {
            app.MapGet("/reports/adoptions/current-month", (HttpResponse resp) =>
            {
                try
                {
                    var reportsService = new Services.ReportsService();
                    byte[] pdfBytes = reportsService.GenerateCurrentMonthAdoptionReport();
                    resp.Headers.Append("Access-Control-Expose-Headers", "Content-Disposition, Content-Type");
                    return Results.File(pdfBytes, "application/pdf", fileDownloadName: $"AdoptionReport_{DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")}.pdf");
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
