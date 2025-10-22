using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.History
{
    public class AnimalResponsibleHistoryDTO
    {
        public string Id { get; set; }
        public DateTime AssignedDate { get; set; }
        public string ResponsibleId { get; set; }
        public string AnimalId { get; set; }
    }
}
