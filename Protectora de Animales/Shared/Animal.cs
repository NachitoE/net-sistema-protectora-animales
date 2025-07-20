using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Animal : IIdentifiable
    {
        #region Fields/Properties
        public string Id
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
        public string Species
        {
            get
            {
                return _species;
            }
            set
            {
                _species = value;
            }
        }
        private string _species;
        #endregion
    }
}
