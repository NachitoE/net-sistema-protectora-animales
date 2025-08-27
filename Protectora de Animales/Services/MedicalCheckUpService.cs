using System;
using System.Collections.Generic;
using Domain;

namespace Services
{
    public class MedicalCheckUpService : BaseService<MedicalCheckUp>
    {
        private MedicalCheckUpService()
        {
            if (IsEmpty())
                LoadDummyData();
        }

        private void LoadDummyData()
        {
            Save(new MedicalCheckUp(
                Guid.NewGuid().ToString(),
                "user-3",
                new DateTime(2023, 5, 15),
                "Buena salud general.",
                "animal-2"
            ));

            Save(new MedicalCheckUp(
                Guid.NewGuid().ToString(),
                "user-2",
                new DateTime(2023, 6, 10),
                "Desparasitado correctamente.",
                "animal-1"
            ));

            Save(new MedicalCheckUp(
                Guid.NewGuid().ToString(),
                "user-4",
                new DateTime(2023, 7, 5),
                "Fiebre leve detectada.",
                "animal-4"
            ));
        }

        protected override string _filePath => "medicalCheckUp.json";
        public static readonly MedicalCheckUpService Instance = new MedicalCheckUpService();
        public override List<MedicalCheckUp> GetAll()
        {
            return base.GetAll();
        }
        public override MedicalCheckUp GetByID(string id)
        {
            return base.GetByID(id);
        }
        public override void Save(MedicalCheckUp obj)
        {
            base.Save(obj);
        }
        public override void Delete(MedicalCheckUp obj)
        {
            base.Delete(obj);
        }
    }
}
