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
