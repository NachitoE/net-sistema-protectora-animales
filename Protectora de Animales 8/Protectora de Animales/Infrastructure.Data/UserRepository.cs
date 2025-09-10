using Domain;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data
{
    public class UserRepository
    {
        public DBContext CreateContext() 
        {
            return new DBContext();
        }

        public void Add(User u) 
        {
            DBContext context = CreateContext();
            context.Users.Add(u);
            context.SaveChanges();

        }

        public User? Get(int id)
        {
            DBContext context = CreateContext();
            User? foundUser = context.Users.Find(id);
            return null;
        }

        public bool Update(User u) 
        {
            DBContext context = this.CreateContext();
            User? existingUser = context.Users.Find(u.Id);
            if (existingUser != null)
            {
                existingUser.Name = u.Name;
                existingUser.SurName = u.SurName;
                existingUser.DNI = u.DNI;
                existingUser.UserName = u.UserName;
                existingUser.Password = u.Password;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            DBContext context = this.CreateContext();
            User? existingUser = context.Users.Find(id);
            if (existingUser != null)
            {
                context.Users.Remove(existingUser);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
