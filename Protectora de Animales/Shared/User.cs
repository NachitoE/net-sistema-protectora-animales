namespace Shared
{
    public class User : IIdentifiable
    {
        #region Fields/Properties
        private Type _typeUser = Type.Admin;
        private string _id;
        public string Id
        {
            get => _id;
            set => _id = value;
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private string _dni;
        public string DNI
        {
            get => _dni;
            set => _dni = value;
        }

        #endregion
        public User(string id, string name, string dni)
        {
            Id = id;
            Name = name;
            DNI = dni;
        }

        enum Type
        {
            Admin, Adoptante, Transito, Voluntario
        }
    }
}