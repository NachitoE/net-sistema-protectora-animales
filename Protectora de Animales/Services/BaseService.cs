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
        public virtual T GetByID(string id) => _list.First(x => x.Id == id);
        public virtual void Save(T obj)
        {
            if (string.IsNullOrEmpty(obj.Id))
                obj.Id = Guid.NewGuid().ToString();
            var exists = _list.Exists(x => x.Id == obj.Id);
            if (exists)
                Delete(obj);

            _list.Add(obj);
            Persist();
        }
        public virtual void Delete(T obj)
        {
            _list.RemoveAll(x => x.Id == obj.Id);
            Persist();
        }
        protected virtual void Persist()
        {
            string location = GetFileLocation();
            if (!Directory.Exists(GetFileDir()))
                Directory.CreateDirectory(GetFileDir());

            var json = JsonSerializer.Serialize(_list, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(location, json);
        }
        protected virtual List<T> Load()
        {
            if (!File.Exists(GetFileLocation()))
                return new List<T>();

            var json = File.ReadAllText(GetFileLocation());
            var deserializedList = JsonSerializer.Deserialize<List<T>>(json);
            if (deserializedList == null)
            {
                return new List<T>();
            }
            return deserializedList;
        }
        public bool IsEmpty() => _list.Count == 0;

        private string GetFileDir() => Path.GetDirectoryName(GetFileLocation());
        private string GetFileLocation() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VeterinariaNet", _filePath);
    }
}
