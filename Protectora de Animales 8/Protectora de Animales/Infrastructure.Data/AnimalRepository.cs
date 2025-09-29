using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AnimalRepository
    {
        public DBContext CreateContext()
        {
            return new DBContext();
        }

        public void Add(Animal a)
        {
            DBContext context = CreateContext();
            a.UserId = null; // hotfix para evitar crashes, no deberia estar asignado a ningun user pero con "" tira error
            context.Animals.Add(a);
            context.SaveChanges();

        }

        public Animal? Get(string id)
        {
            DBContext context = CreateContext();
            Animal? foundAnimal = context.Animals.Find(id);
            return foundAnimal;
        }

        public IEnumerable<Animal> GetAll()
        {
            DBContext context = CreateContext();
            return context.Animals;
        }

        public bool Update(Animal a)
        {
            DBContext context = this.CreateContext();
            Animal? existingAnimal = context.Animals.Find(a.Id);
            if (existingAnimal != null)
            {
                existingAnimal.Name = a.Name;
                existingAnimal.UserId = a.UserId;
                existingAnimal.Description = a.Description;
                existingAnimal.BirthDate = a.BirthDate;
                existingAnimal.AnimalState = a.AnimalState;
                existingAnimal.Species = a.Species;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(string id)
        {
            DBContext context = this.CreateContext();
            Animal? existingAnimal = context.Animals.Find(id);
            if (existingAnimal != null)
            {
                context.Animals.Remove(existingAnimal);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
