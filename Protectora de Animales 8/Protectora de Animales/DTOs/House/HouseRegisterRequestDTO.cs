using System;

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

