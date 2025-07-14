using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Shared;

namespace Services
{
    public abstract class BaseService<T> where T : IIdentifiable
    {
        protected abstract string _filePath { get; }
        private List<T> _list;
        protected BaseService()
        {
            _list = Load();
        }
        public virtual List<T> GetAll() => _list;
        public virtual T GetByID(string id) => _list.First(x => x.ID == id);
        public virtual void Save(T obj)
        {
            if (string.IsNullOrEmpty(obj.ID))
                obj.ID = Guid.NewGuid().ToString();

            _list.Add(obj);
            Persist();
        }
        public virtual void Delete(T obj)
        {
            _list.RemoveAll(x => x.ID == obj.ID);
            Persist();
        }
        protected virtual void Persist()
        {
            var json = JsonSerializer.Serialize(_list, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
        protected virtual List<T> Load()
        {
            if (!File.Exists(_filePath))
                return new List<T>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }
    }
}
