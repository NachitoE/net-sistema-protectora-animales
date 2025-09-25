using System;

namespace Domain
{
    public class User
    {
        #region Fields/Properties
        public const int MAX_CAPACITY_VOLUNTARIOS = 2;

        private UserType _userType = UserType.Admin;
        private UserStatus _userStatus = UserStatus.Active;
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
        public string Dni
        {
            get => _dni;
            set => _dni = value;
        }
        public UserType UserType
        {
            get => _userType;
            set => _userType = value;
        }
        public UserStatus UserStatus
        {
            get => _userStatus;
            set => _userStatus = value;
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
        public User(string id, string name, string surName, string dni, UserType userType, string userName, string password, UserStatus userStatus = UserStatus.Active)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Dni = dni;
            UserType = userType;
            UserName = userName;
            Password = password;
            UserStatus = userStatus;
        }
    }
    public enum UserType
    {
        Admin, Adoptante, Transito, Voluntario
    }
    
    public enum UserStatus
    {
        Active, Inactive, PendingHouse
    }
}