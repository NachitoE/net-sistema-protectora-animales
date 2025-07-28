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
        
        //TODO: Species es una clase aparte?
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
        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }
        private DateTime _birthDate;
        //TODO: AnimalState
        public string UserId
        {
            get => _userId;
            set => _userId = value;
        }
        private string _userId; //owner
        #endregion
    }
}
