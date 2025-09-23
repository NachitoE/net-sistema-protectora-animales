using DTOs.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.User
{
    public class TransitoRegisterRequestDTO
    {
            // Datos de User
            public string Name { get; set; }
            public string SurName { get; set; }
            public string DNI { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }

            // Datos de la House
            public HouseRegisterRequestDTO House { get; set; }
        
    }
}

