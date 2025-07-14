using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Services
{
    public class AdopcionService : BaseService<Adopcion>
    {
        public static readonly AdopcionService Instance = new AdopcionService();
        protected override string _filePath => "adoptions.json";
        public override List<Adopcion> GetAll()
        {
            return base.GetAll();
        }
        public override Adopcion GetByID(string id)
        {
            return base.GetByID(id);
        }
        public override void Save(Adopcion obj)
        {
            base.Save(obj);
        }
        public override void Delete(Adopcion obj)
        {
            base.Delete(obj);
        }
    }
}
