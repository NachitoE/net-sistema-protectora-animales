using System;
using System.Collections.Generic;
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
            Save(new Animal("1", "Firulais", Animal.SpeciesEn.Perro, new DateTime(2018, 5, 20), "user-1", Animal.AnimalStateEn.Disponible,"Como es el bichito"));
            Save(new Animal("2", "Miau", Animal.SpeciesEn.Gato, new DateTime(2020, 3, 15), "user-2", Animal.AnimalStateEn.Disponible, "Como es el bichito"));
            Save(new Animal("3", "Bunny", Animal.SpeciesEn.Conejo, new DateTime(2021, 7, 10), "user-3", Animal.AnimalStateEn.Disponible, "Como es el bichito"));
            Save(new Animal("4", "Lola", Animal.SpeciesEn.Gato, new DateTime(2019, 2, 5), "user-4", Animal.AnimalStateEn.Adoptado, ""));
            Save(new Animal("5", "Rex", Animal.SpeciesEn.Perro, new DateTime(2017, 11, 30), "user-5", Animal.AnimalStateEn.Adoptado,"Como es el bichito"));
            Save(new Animal("6", "Coco", Animal.SpeciesEn.Conejo, new DateTime(2022, 1, 25), "user-6", Animal.AnimalStateEn.Disponible, "Como es el bichito"));
            Save(new Animal("7", "Pepi", Animal.SpeciesEn.Pajaro, new DateTime(2016, 8, 18), "user-7", Animal.AnimalStateEn.Adoptado, "Como es el bichito"));

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
