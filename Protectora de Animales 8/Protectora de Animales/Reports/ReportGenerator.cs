using FastReport;
using FastReport.Data.JsonConnection;
using FastReport.Export.PdfSimple;

namespace Reports
{
    public class ReportGenerator
    {
        private readonly string _reportPath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reportFileName">Nombre del .frx del reporte, ubicado en Reports/ReportFiles (sin el .frx)</param>
        public ReportGenerator(string reportFileName)
        {
            string basePath = AppContext.BaseDirectory;
            _reportPath = Path.Combine(basePath, "ReportFiles", $"{reportFileName}.frx");
        }
        public byte[] GenerateReportPDF(string jsonData)
        {
            using var report = new Report();
            if (!File.Exists(_reportPath))
            {
                throw new FileNotFoundException($"Report file not found: {_reportPath}");
            }
            report.Load(_reportPath);

            var csb = new JsonDataSourceConnectionStringBuilder
            {
                Json = jsonData,
                Encoding = "utf-8",
            };

            var jsonConn = report.Dictionary.Connections
                .OfType<JsonDataSourceConnection>()
                .FirstOrDefault();

            if (jsonConn == null)
                throw new InvalidOperationException("No existe una conexión llamada 'JSON' en el .frx");

            jsonConn.ConnectionString = csb.ToString();
            jsonConn.CreateAllTables();

            // export pdf
            report.Prepare();

            using var ms = new MemoryStream();
            using var pdf = new PDFSimpleExport();
            report.Export(pdf, ms);
            return ms.ToArray();
        }
    }
}
