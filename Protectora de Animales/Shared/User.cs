namespace Shared
{
    public class User : IIdentifiable
    {
        #region Fields/Properties
        private Type _userType = Type.Admin;
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

        private string _surName;
        public string SurName
        {
            get => _surName;
            set => _surName = value;
        }
        private string _dni;
        public string DNI
        {
            get => _dni;
            set => _dni = value;
        }
        public Type UserType
        {
            get => _userType;
            set => _userType = value;
        }

        #endregion
        public User(string id, string name, string surname, string dni)
        {
            Id = id;
            Name = name;
            SurName = surname;
            DNI = dni;
        }

        public enum Type
        {
            Admin, Adoptante, Transito, Voluntario
        }
    }
}