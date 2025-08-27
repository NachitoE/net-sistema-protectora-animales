using Domain;
using System;

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
            Save(new House(
                Guid.NewGuid().ToString(),
                "user-2",
                "Bv. Oroño",
                123,
                2
            ));

            Save(new House(
                Guid.NewGuid().ToString(),
                "user-3",
                "Av. Siempre Viva",
                742,
                3
            ));

            Save(new House(
                Guid.NewGuid().ToString(),
                "user-4",
                "Entre Rios",
                2010,
                5
            ));
            Save(new House(
                Guid.NewGuid().ToString(),
                "user-2",
                "Bv. Oroño",
                123,
                2
            ));
        }

        protected override string _filePath => "house.json";
        public static readonly HouseService Instance = new HouseService();
    }
}
