using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Services
{
    public class SeguimientoService : BaseService<Seguimiento>
    {
        public override List<Seguimiento> GetAll()
        {
            return base.GetAll();
        }
        public override Seguimiento GetByID(string id)
        {
            return base.GetByID(id);
        }
        public override void Save(Seguimiento obj)
        {
            base.Save(obj);
        }
        public override void Delete(Seguimiento obj)
        {
            base.Delete(obj);
        }
    }
}
