using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AdoptionRepository
    {
        public DBContext CreateContext()
        {
            return new DBContext();
        }

        public void Add(Adoption adoption)
        {
            DBContext context = CreateContext();
            context.Adoptions.Add(adoption);
            context.SaveChanges();
        }

        public Adoption? Get(string id)
        {
            DBContext context = CreateContext();
            Adoption? foundAdoption = context.Adoptions
                .Include(a => a.Animal)
                .Include(a => a.User)
                .FirstOrDefault(a => a.Id == id);
            return foundAdoption;
        }

        public IEnumerable<Adoption> GetAll()
        {
            DBContext context = CreateContext();
            return context.Adoptions
                .Include(a => a.Animal)
                .Include(a => a.User)
                .ToList();
        }

        public bool Update(Adoption adoption)
        {
            DBContext context = this.CreateContext();
            Adoption? existingAdoption = context.Adoptions.Find(adoption.Id);
            if (existingAdoption != null)
            {
                existingAdoption.AnimalId = adoption.AnimalId;
                existingAdoption.UserId = adoption.UserId;
                existingAdoption.AdoptionRequestDate = adoption.AdoptionRequestDate;
                existingAdoption.AdoptionResponseDate = adoption.AdoptionResponseDate;
                existingAdoption.State = adoption.State;
                existingAdoption.Description = adoption.Description;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(string id)
        {
            DBContext context = this.CreateContext();
            Adoption? existingAdoption = context.Adoptions.Find(id);
            if (existingAdoption != null)
            {
                context.Adoptions.Remove(existingAdoption);
                context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
