using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class User : IIdentifiable
    {
        #region Fields/Properties
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        private string _id;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private string _name;
        public string DNI
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }
        public string _dni;
        #endregion
    }
}
