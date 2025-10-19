using DTOs;
using Infrastructure.API.Interfaces;

namespace WindowsForms.Handlers
{
    public class WinFormDownloadHandler : IDownloadHandler
    {
        public async Task TriggerDownloadAsync(DownloadFile file)
        {
            using var sfd = new SaveFileDialog
            {
                FileName = file!.FileName,
                Filter = "PDF (*.pdf)|*.pdf|Todos (*.*)|*.*"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllBytes(sfd.FileName, file!.Content);
        }
    }
}
