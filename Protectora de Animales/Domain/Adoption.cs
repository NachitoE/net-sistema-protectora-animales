using System;

namespace Domain
{
    public class Adoption : IIdentifiable
    {
        #region Fields/Properties
        private string _id;
        private string _animalId;
        private string _userId;
        private DateTime _adoptionDate;
        private string _state;
        private string _description;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string AnimalID
        {
            get { return _animalId; }
            set { _animalId = value; }
        }
        public string UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public DateTime AdoptionDate
        {
            get { return _adoptionDate; }
            set { _adoptionDate = value; }
        }

        public string State //TODO: enum?
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }

        }

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public User User
        {
            get => default;
            set
            {
            }
        }


        #endregion

        #region Constructor
        public Adoption(string idAdopcion, string animalId, string userID, DateTime fechaAdopcion, string estado, string descripcion)
            {
                _id = idAdopcion;
                _animalId = animalId;
                _userId = userID;
                _adoptionDate = fechaAdopcion;
                _state = estado;
                _description = descripcion;
            }
            #endregion

       
    }
}
