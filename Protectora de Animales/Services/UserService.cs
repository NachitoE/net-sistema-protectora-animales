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
       /* private UserService()
        {
            if (IsEmpty())
                LoadDummyData();
        }

        /* private void LoadDummyData()
       {Save(new User("user-1", "UTN", "12345678")
           {
               SurName = "Rosario",
               UserType = User.Type.Admin
           });

           Save(new User("user-2", "Camila", "87654321")
           {
               SurName = "Stella",
               UserType = User.Type.Adoptante
           });

           Save(new User("user-3", "Ignacio", "44180117")
           {
               SurName = "Esteves",
               UserType = User.Type.Voluntario
           });

           Save(new User("user-4", "Nicolás", "11223344")
           {
               SurName = "Salerno",
               UserType = User.Type.Transito
           });
       }*/


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
    }
}
