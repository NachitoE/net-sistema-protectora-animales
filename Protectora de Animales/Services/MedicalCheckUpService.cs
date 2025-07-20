using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Services
{
    public class MedicalCheckUpService : BaseService<MedicalCheckUp>
    {
        protected override string _filePath => "medicalCheckUp.json";
        public override List<MedicalCheckUp> GetAll()
        {
            return base.GetAll();
        }
        public override MedicalCheckUp GetByID(string id)
        {
            return base.GetByID(id);
        }
        public override void Save(MedicalCheckUp obj)
        {
            base.Save(obj);
        }
        public override void Delete(MedicalCheckUp obj)
        {
            base.Delete(obj);
        }
    }
}
