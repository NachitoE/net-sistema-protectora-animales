using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SightingRegisterDTO
    {
        public string SightingAddressName { get; set; }
        public string SightingAddressNumber { get; set; }
        public DateTime SightingDateTime { get; set; }
        public string SightingDescription { get; set; }

    }
}
