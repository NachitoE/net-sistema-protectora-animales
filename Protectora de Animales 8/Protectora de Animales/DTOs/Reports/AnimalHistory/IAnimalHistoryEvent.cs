using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Reports.AnimalHistory
{
    public interface IAnimalHistoryEvent
    {
        public string Description { get; }
        public DateTime Date { get; }
    }
}
