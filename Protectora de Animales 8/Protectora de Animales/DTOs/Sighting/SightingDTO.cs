using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Sighting
{
    public class SightingDTO
    {
            public string Id { get; set; }
            public string SightingAdressName { get; set; }
            public string SightingAdressNumber { get; set; }
            public DateTime SightingDatetime { get; set; }
            public string SightingDescription { get; set; }
            public string SightingState { get; set; }
    }

    
}
