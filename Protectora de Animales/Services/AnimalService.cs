using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Services
{
    public class AnimalService : BaseService<Animal>
    {
        private AnimalService()
        {
            if (IsEmpty())
                LoadDummyData();
        }

        private void LoadDummyData()
        {
            Save(new Animal
            {
                Id = "animal-1",
                Name = "Luna",
                Species = "Perro",
                BirthDate = new DateTime(2021, 3, 12),
                UserId = "user-2"
            });

            Save(new Animal
            {
                Id = "animal-2",
                Name = "Milo",
                Species = "Gato",
                BirthDate = new DateTime(2022, 7, 25),
                UserId = "user-3"
            });

            Save(new Animal
            {
                Id = "animal-3",
                Name = "Toby",
                Species = "Perro",
                BirthDate = new DateTime(2020, 1, 5),
                UserId = "user-2"
            });

            Save(new Animal
            {
                Id = "animal-4",
                Name = "Lola",
                Species = "Gata",
                BirthDate = new DateTime(2019, 10, 30),
                UserId = "user-4"
            });
        }


        protected override string _filePath => "animals.json";
        public static readonly AnimalService Instance = new AnimalService();
        public override List<Animal> GetAll()
        {
            return base.GetAll();
        }
        public override Animal GetByID(string id)
        {
            return base.GetByID(id);
        }
        public override void Save(Animal obj)
        {
            base.Save(obj);
        }
        public override void Delete(Animal obj)
        {
            base.Delete(obj);
        }
    }
}
