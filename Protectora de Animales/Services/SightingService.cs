using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SightingService : BaseService<Sighting>
    {
        private SightingService()
        {
            if (IsEmpty())
                LoadDummyData();
        }

        private void LoadDummyData()
        {
            Save(new Sighting
            {
                Id = Guid.NewGuid().ToString(),
                SightingAddressName = "Mitre",
                SightingAddressNumber = 2000,
                SightingDateTime = new DateTime(2024, 9, 20, 15, 30, 0),
                AnimalId = "animal-1"
            });

            Save(new Sighting
            {
                Id = Guid.NewGuid().ToString(),
                SightingAddressName = "Zeballos",
                SightingAddressNumber = 1341,
                SightingDateTime = new DateTime(2024, 10, 3, 18, 45, 0),
                AnimalId = "animal-3"
            });

            Save(new Sighting
            {
                Id = Guid.NewGuid().ToString(),
                SightingAddressName = "Entre Rios",
                SightingAddressNumber = 3000,
                SightingDateTime = new DateTime(2024, 11, 12, 10, 15, 0),
                AnimalId = "animal-4"
            });
        }

        protected override string _filePath => "sightings.json";
        public static readonly SightingService Instance = new SightingService();
    }
}
