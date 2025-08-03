namespace Shared
{
    public class User : IIdentifiable
    {
        #region Fields/Properties
        public const int MAX_CAPACITY_VOLUNTARIOS = 2;

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
        private string _username;
        public string UserName
        {
            get => _username;
            set => _username = value;
        }
        private string _password;
        public string Password
        {
            get => _password;
            set => _password = value;
        }
        #endregion
        public User(string id, string name, string surname, string dni, Type usertype, string username, string password)
        {
            Id = id;
            Name = name;
            SurName = surname;
            DNI = dni;
            UserType = usertype;
            UserName = username;
            Password = password;

        }

        public enum Type
        {
            Admin, Adoptante, Transito, Voluntario
        }

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public House House
        {
            get => default;
            set
            {
            }
        }
    }
}