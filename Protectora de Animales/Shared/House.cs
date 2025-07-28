using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class House
    {
        #region Fields/Properties
        private string _houseId;
        private string _userId;
        private string _address;
        private int _addressNumber;
        private int _capacity;
        public string HouseId
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
    }
}
