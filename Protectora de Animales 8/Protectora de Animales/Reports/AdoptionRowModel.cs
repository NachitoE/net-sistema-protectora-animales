using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public class AdoptionRowModel
    {
        public string AnimalName { get; set; }
        public string AdopterUserName { get; set; }
        public DateTime AdoptionRequestDate { get; set; }
        public DateTime? AdoptionResponseDate { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
    }
}
