using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Services
{
    public class BaseService<T> where T : IIdentifiable
    {
        private List<T> _list;
        public virtual List<T> GetAll() => _list;
        public virtual T GetByID(string id) => _list.First(x => x.ID == id);
        public virtual void Save(T obj) => _list.Add(obj);
        public virtual void Delete(T obj) => _list.Remove(obj);
    }
}
