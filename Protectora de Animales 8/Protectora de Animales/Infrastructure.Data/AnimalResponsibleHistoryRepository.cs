using Domain;
using Domain.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AnimalResponsibleHistoryRepository
    {
        public DBContext CreateContext()
        {
            return new DBContext();
        }

        public void Add(AnimalResponsibleHistory a)
        {
            DBContext context = CreateContext();
            context.AnimalResponsibleHistories.Add(a);
            context.SaveChanges();

        }

        public AnimalResponsibleHistory? Get(string id)
        {
            DBContext context = CreateContext();
            AnimalResponsibleHistory? foundAnimalRH = context.AnimalResponsibleHistories.Find(id);
            return foundAnimalRH;
        }

        public IEnumerable<AnimalResponsibleHistory> GetAll()
        {
            DBContext context = CreateContext();
            return context.AnimalResponsibleHistories;
        }

        public bool Update(AnimalResponsibleHistory a)
        {
            DBContext context = this.CreateContext();
            AnimalResponsibleHistory? existingAnimalRH = context.AnimalResponsibleHistories.Find(a.Id);
            if (existingAnimalRH != null)
            {
                existingAnimalRH.ResponsibleId = a.ResponsibleId;
                existingAnimalRH.AnimalId = a.AnimalId;
                existingAnimalRH.AssignedDate = a.AssignedDate;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(string id)
        {
            DBContext context = this.CreateContext();
            AnimalResponsibleHistory? existingAnimal = context.AnimalResponsibleHistories.Find(id);
            if (existingAnimal != null)
            {
                context.AnimalResponsibleHistories.Remove(existingAnimal);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
