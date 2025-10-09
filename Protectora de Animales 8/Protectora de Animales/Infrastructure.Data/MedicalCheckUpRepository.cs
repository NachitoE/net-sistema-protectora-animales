using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MedicalCheckUpRepository
    {
        public DBContext CreateContext()
        {
            return new DBContext();
        }
        public void Add(MedicalCheckUp checkUp)
        {
            DBContext context = CreateContext();
            context.MedicalCheckUps.Add(checkUp);
            context.SaveChanges();
        }

        public MedicalCheckUp? Get(string id)
        {
            DBContext context = CreateContext();
            return context.MedicalCheckUps
                .FirstOrDefault(c => c.Id == id);
        }

        public List<MedicalCheckUp> GetAll()
        {
            DBContext context = CreateContext();
            return context.MedicalCheckUps
                .ToList();
        }

        public bool Update(MedicalCheckUp checkUp)
        {
            DBContext context = CreateContext();
            context.MedicalCheckUps.Update(checkUp);
            return context.SaveChanges() > 0;
        }

        public bool Delete(string id)
        {
            DBContext context = CreateContext();
            var checkUp = context.MedicalCheckUps.Find(id);
            if (checkUp == null) return false;
            context.MedicalCheckUps.Remove(checkUp);
            return context.SaveChanges() > 0;
        }
    }
}
