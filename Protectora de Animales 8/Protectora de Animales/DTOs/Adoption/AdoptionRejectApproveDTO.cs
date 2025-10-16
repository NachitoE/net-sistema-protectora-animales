using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Adoption
{
    public class AdoptionRejectApproveDTO
    {
        public bool Approved { get; set; }
        public DateTime? AdoptionResponseDate { get; set; }
    }
}
