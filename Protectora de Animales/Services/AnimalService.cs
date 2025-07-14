using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Services
{
    public class AnimalService : BaseService<Animal>
    {
        public override List<Animal> GetAll()
        {
            return base.GetAll();
        }
        public override Animal GetByID(string id)
        {
            return base.GetByID(id);
        }
        public override void Save(Animal obj)
        {
            base.Save(obj);
        }
        public override void Delete(Animal obj)
        {
            base.Delete(obj);
        }
    }
}
