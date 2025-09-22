using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.House
{
    public class HouseRegisterRequestDTO
    {
            public string UserId { get; set; }
            public string Address { get; set; }
            public int AddressNumber { get; set; }
            public int Capacity { get; set; }
       
    }
}

