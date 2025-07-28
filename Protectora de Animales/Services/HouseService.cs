using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HouseService : BaseService<House>
    {
        protected override string _filePath => "house.json";
    }
}
