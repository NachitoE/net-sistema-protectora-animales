using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Services
{
    public class UserService : BaseService<User>
    {
       private UserService()
        {
            if (IsEmpty())
                LoadDummyData();
        }

        private void LoadDummyData()
        {
            Save(new User("user-1", "UTN", "Rosario", "12345678", User.Type.Admin, "utn", "123"));
            Save(new User("user-2", "Camila", "Stella", "87654321", User.Type.Adoptante, "cami", "123"));
            Save(new User("user-3", "Ignacio", "Esteves", "44180117", User.Type.Voluntario, "nacho", "123"));
            Save(new User("user-4", "Nicolás", "Salerno", "11223344", User.Type.Transito, "niko", "123"));
        }


        public static readonly UserService Instance = new UserService();
        protected override string _filePath => "users.json";

        public override List<User> GetAll()
        {
            return base.GetAll();
        }
        public override User GetByID(string id)
        {
            return base.GetByID(id);
        }
        public override void Save(User obj)
        {
            base.Save(obj);
        }
        public override void Delete(User obj)
        {
            base.Delete(obj);
        }
        public bool IsValidUser(string userName, string password)
        {
            foreach (User user in GetAll())
            {
                if (user.UserName == userName && user.Password == password) return true;
            }
            return false;
        }
        public bool UserNameExists(string userName)
        {
            foreach (User user in GetAll())
            {
                if (user.UserName == userName) return true;
            }
            return false;
        }

        public static int GetRemainingCapacity(User user)
        {
            if (user.UserType == User.Type.Voluntario)
            {
                int userAnimalsCount = AnimalService.Instance.GetAll().Count(a => a.UserId == user.Id);
                return User.MAX_CAPACITY_VOLUNTARIOS - userAnimalsCount;
            }
            else if (user.UserType == User.Type.Transito)
            {
                var house = HouseService.Instance.GetAll().FirstOrDefault(h => h.UserId == user.Id);
                if (house == null)
                    return 0; // No house found for the user

                return house.Capacity - 
                    AnimalService.Instance.GetAll().Count(a => a.UserId == user.Id);
            }
            return 0;
        }
    }
}
