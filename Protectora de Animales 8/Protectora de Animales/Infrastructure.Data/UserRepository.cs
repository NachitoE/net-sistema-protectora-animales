using Domain;

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

        public User? Get(string id)
        {
            DBContext context = CreateContext();
            User? foundUser = context.Users.Find(id);
            return foundUser;
        }

        public IEnumerable<User> GetAll()
        {
            DBContext context = CreateContext();
            return context.Users;
        }

        public bool Update(User u) 
        {
            DBContext context = this.CreateContext();
            User? existingUser = context.Users.Find(u.Id);
            if (existingUser != null)
            {
                existingUser.Name = u.Name;
                existingUser.SurName = u.SurName;
                existingUser.Dni = u.Dni;
                existingUser.UserName = u.UserName;
                existingUser.Password = u.Password;
                existingUser.UserType = u.UserType;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(string id)
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

        public User? Login(string userName, string password)
        {
            DBContext context = this.CreateContext();
            return context.Users
                .FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }

        public bool ExistsByUserName(string userName)
        {
            DBContext context = this.CreateContext();
            return context.Users
                .FirstOrDefault(u => u.UserName == userName) != null;
        }
        public List<User> FilterByCriteria(string? name = null, string? surName = null,
    string? dni = null, string? userType = null, string? userName = null, string? userStatus = null)
        {
            DBContext context = CreateContext();
            IQueryable<User> query = context.Users;

            if (!string.IsNullOrEmpty(name))
                query = query.Where(u => u.Name.Contains(name));

            if (!string.IsNullOrEmpty(surName))
                query = query.Where(u => u.SurName.Contains(surName));

            if (!string.IsNullOrEmpty(dni))
                query = query.Where(u => u.Dni == dni);

            if (!string.IsNullOrEmpty(userType) && Enum.TryParse<UserType>(userType, out var type))
                query = query.Where(u => u.UserType == type);

            if (!string.IsNullOrEmpty(userName))
                query = query.Where(u => u.UserName.Contains(userName));

            if (!string.IsNullOrEmpty(userStatus) && Enum.TryParse<UserStatus>(userStatus, out var status))
                query = query.Where(u => u.UserStatus == status);

            return query.ToList();
        }
    }
}
