using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Shared;

namespace Services
{
    public abstract class BaseService<T> where T : IIdentifiable
    {
        protected abstract string _filePath { get; }
        private List<T> _list;
        private DateTime _lastFileReadWriteTime;

        protected BaseService()
        {
            _list = Load();
            _lastFileReadWriteTime = GetFileWriteTime();
        }

        public virtual List<T> GetAll()
        {
            var currentWriteTime = GetFileWriteTime();
            if (currentWriteTime > _lastFileReadWriteTime)
            {
                _list = Load();
                _lastFileReadWriteTime = currentWriteTime;
            }
            return _list;
        }

        public virtual T GetByID(string id) => GetAll().First(x => x.Id == id);

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
            _lastFileReadWriteTime = GetFileWriteTime();
        }

        protected virtual List<T> Load()
        {
            if (!File.Exists(GetFileLocation()))
                return new List<T>();

            var json = File.ReadAllText(GetFileLocation());
            var deserializedList = JsonSerializer.Deserialize<List<T>>(json);
            return deserializedList ?? new List<T>();
        }

        public bool IsEmpty() => GetAll().Count == 0;

        private string GetFileDir() => Path.GetDirectoryName(GetFileLocation());
        private string GetFileLocation() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VeterinariaNet", _filePath);

        private DateTime GetFileWriteTime()
        {
            var file = GetFileLocation();
            return File.Exists(file) ? File.GetLastWriteTime(file) : DateTime.MinValue;
        }
    }
}
