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
            _reportPath = Path.Combine(basePath, "Reports", "ReportFiles", $"{reportFileName}.frx");
        }
        public byte[] GenerateReportPDF(string jsonData)
        {
            using var report = new Report();
            report.Load(_reportPath);

            var csb = new JsonDataSourceConnectionStringBuilder
            {
                Json = jsonData,
                Encoding = "utf-8",
            };

            var jsonConn = new JsonDataSourceConnection
            {
                Name = "JSON",
                ConnectionString = csb.ToString()
            };

            //create connections + tables
            report.Dictionary.Connections.Clear();
            report.Dictionary.Connections.Add(jsonConn);
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
