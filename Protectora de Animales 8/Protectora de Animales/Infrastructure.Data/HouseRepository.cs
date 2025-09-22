using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class HouseRepository
    {
        public DBContext CreateContext()
        {
            return new DBContext();
        }

        public void Add(House h)
        {
            DBContext context = CreateContext();
            context.Houses.Add(h);
            context.SaveChanges();

        }

        public House? Get(string id)
        {
            DBContext context = CreateContext();
            House? foundHouse = context.Houses.Find(id);
            return foundHouse;
        }

        public IEnumerable<House> GetAll()
        {
            DBContext context = CreateContext();
            return context.Houses;
        }

        public bool Update(House h)
        {
            DBContext context = this.CreateContext();
            House? existingHouse = context.Houses.Find(h.Id);
            if (existingHouse != null)
            {
                existingHouse.Id = h.Id;
                existingHouse.UserId = h.UserId;
                existingHouse.Address = h.Address;
                existingHouse.AddressNumber = h.AddressNumber;
                existingHouse.Capacity = h.Capacity;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(string id)
        {
            DBContext context = this.CreateContext();
            House? existingHouse = context.Houses.Find(id);
            if (existingHouse != null)
            {
                context.Houses.Remove(existingHouse);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
