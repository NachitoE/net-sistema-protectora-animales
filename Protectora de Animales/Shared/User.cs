namespace Shared
{
    public class User : IIdentifiable
    {
        #region Fields/Properties

        private string _id;
        public string ID
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
            ID = id;
            Name = name;
            DNI = dni;
        }
    }
}