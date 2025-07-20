using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Services
{
    public class AdoptionService : BaseService<Adoption>
    {
        public static readonly AdoptionService Instance = new AdoptionService();
        protected override string _filePath => "adoptions.json";
        public override List<Adoption> GetAll()
        {
            return base.GetAll();
        }
        public override Adoption GetByID(string id)
        {
            return base.GetByID(id);
        }
        public override void Save(Adoption obj)
        {
            base.Save(obj);
        }
        public override void Delete(Adoption obj)
        {
            base.Delete(obj);
        }
    }
}
