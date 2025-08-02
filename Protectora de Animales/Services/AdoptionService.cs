using System;
using System.Collections.Generic;
using Shared;

namespace Services
{
    public class AdoptionService : BaseService<Adoption>
    {
        private AdoptionService()
        {
            if (IsEmpty())
                LoadDummyData();
        }

        private void LoadDummyData()
        {
            Save(new Adoption(
                Guid.NewGuid().ToString(),
                "animal-1",
                "user-2",
                new DateTime(2024, 1, 20),
                "EN REVISION",
                "Solicitud reciente, pendiente de evaluación."
            ));

            Save(new Adoption(
                Guid.NewGuid().ToString(),
                "animal-3",
                "user-2",
                new DateTime(2024, 2, 10),
                "ACEPTADA",
                "El animal fue entregado con éxito al adoptante."
            ));

            Save(new Adoption(
                Guid.NewGuid().ToString(),
                "animal-2",
                "user-3",
                new DateTime(2024, 3, 5),
                "RECHAZADA",
                "El hogar no cumplía con los requisitos mínimos."
            ));

            Save(new Adoption(
                Guid.NewGuid().ToString(),
                "animal-4",
                "user-4",
                new DateTime(2024, 4, 3),
                "EN REVISION",
                "El usuario se mostró muy entusiasmado en la entrevista inicial."
            ));
        }


        public static readonly AdoptionService Instance = new AdoptionService();
        protected override string _filePath => "adoptions.json";
        public override List<Adoption> GetAll()
        {
            return base.GetAll();
        }
        public override Adoption GetByID(string id)
        {
            return base.GetByID(id);
        }
        public override void Save(Adoption obj)
        {
            base.Save(obj);
        }
        public override void Delete(Adoption obj)
        {
            base.Delete(obj);
        }
    }
}
