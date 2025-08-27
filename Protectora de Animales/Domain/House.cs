
namespace Domain
{
    public class House : IIdentifiable
    {
        #region Fields/Properties
        private string _houseId;
        private string _userId;
        private string _address;
        private int _addressNumber;
        private int _capacity;
        public string Id
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public int AddressNumber
        {
            get { return _addressNumber; }
            set { _addressNumber = value; } 
        }
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        #endregion
        public House(string id, string userId, string address, int addressNumber, int capacity)
        {
            Id = id;
            UserId = userId;
            Address = address;
            AddressNumber = addressNumber;
            Capacity = capacity;
        }
    }
}
