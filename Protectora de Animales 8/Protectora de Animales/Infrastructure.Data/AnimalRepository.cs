using Domain;

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

        public List<Animal> FilterByCriteria(string? name = null, string? species = null,
            string? description = null, string? animalState = null, string? userId = null)
        {
            DBContext context = CreateContext();
            IQueryable<Animal> query = context.Animals;

            if (!string.IsNullOrEmpty(name))
                query = query.Where(a => a.Name.Contains(name));

            if (!string.IsNullOrEmpty(species) && Enum.TryParse<Animal.SpeciesEn>(species, out var speciesEnum))
                query = query.Where(a => a.Species == speciesEnum);

            if (!string.IsNullOrEmpty(description))
                query = query.Where(a => a.Description.Contains(description));

            if (!string.IsNullOrEmpty(animalState) && Enum.TryParse<Animal.AnimalStateEn>(animalState, out var stateEnum))
                query = query.Where(a => a.AnimalState == stateEnum);

            if (!string.IsNullOrEmpty(userId))
                query = query.Where(a => a.UserId == userId);

            return query.ToList();
        }
    }
}
