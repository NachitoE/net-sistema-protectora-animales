using Domain;

namespace Infrastructure.Data
{
    public class SightingRepository
    {
        public DBContext CreateContext()
        {
            return new DBContext();
        }
        public void Add(Domain.Sighting s)
        {
            DBContext context = CreateContext();
            context.Sightings.Add(s);
            context.SaveChanges();
        }

        public Sighting? Get(string id)
        {
            DBContext context = CreateContext();
            Sighting? foundSighting = context.Sightings.Find(id);
            return foundSighting;
        }
        public IEnumerable<Domain.Sighting> GetAll()
        {
            DBContext context = CreateContext();
            return context.Sightings;
        }
        public bool Update(Domain.Sighting s)
        {
            using var context = this.CreateContext();
            var existingSighting = context.Sightings.Find(s.Id);

            if (existingSighting != null)
            {
                existingSighting.Sightingstate = s.Sightingstate;

                context.SaveChanges();
                return true;
            }

            return false;
        }
        
        public bool Delete(string id)
        {
            DBContext context = this.CreateContext();
            Domain.Sighting? existingSighting = context.Sightings.Find(id);
            if (existingSighting != null)
            {
                context.Sightings.Remove(existingSighting);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }

}
