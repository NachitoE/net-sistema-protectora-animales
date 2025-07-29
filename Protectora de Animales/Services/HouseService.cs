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
        private HouseService()
        {
            if (IsEmpty())
                LoadDummyData();
        }

        private void LoadDummyData()
        {
            Save(new House
            {
                Id = Guid.NewGuid().ToString(),
                UserId = "user-2",
                Address = "Bv. Oroño",
                AddressNumber = 123,
                Capacity = 2
            });

            Save(new House
            {
                Id = Guid.NewGuid().ToString(),
                UserId = "user-3",
                Address = "Av. Siempre Viva",
                AddressNumber = 742,
                Capacity = 3
            });

            Save(new House
            {
                Id = Guid.NewGuid().ToString(),
                UserId = "user-4",
                Address = "Entre Rios",
                AddressNumber = 2010,
                Capacity = 5
            });
        }

        protected override string _filePath => "house.json";
        public static readonly HouseService Instance = new HouseService();
    }
}
