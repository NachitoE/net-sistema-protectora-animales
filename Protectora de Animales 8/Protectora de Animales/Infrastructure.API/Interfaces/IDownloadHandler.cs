using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.API.Interfaces
{
    public interface IDownloadHandler
    {
        Task TriggerDownloadAsync(DownloadFile file);
    }
}
