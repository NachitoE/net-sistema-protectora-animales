using System;

namespace Domain
{
    public class Adoption
    {
        #region Fields/Properties
        private string _id;
        private string? _animalId;
        private string? _userId;
        private DateTime _adoptionRequestDate;
        private DateTime? _adoptionResponseDate;
        private AdoptionStateEn _state;
        private string _description;
        private User? _user;
        private Animal? _animal;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string AnimalId
        {
            get { return _animalId; }
            set { _animalId = value; }
        }
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public DateTime AdoptionRequestDate
        {
            get { return _adoptionRequestDate; }
            set { _adoptionRequestDate = value; }
        }

        public DateTime? AdoptionResponseDate
        {
            get { return _adoptionResponseDate; }
            set { _adoptionResponseDate = value; }
        }
        public AdoptionStateEn State //TODO: enum?
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }

        }

        public Animal? Animal
        {
            get => _animal;
            set
            {
            }
        }

        public User? User
        {
            get => _user;
            set
            {
            }
        }


        #endregion

        #region Constructor
        public Adoption(string id, string animalId, string userId, DateTime adoptionDate, AdoptionStateEn state, string description)
            {
                Id = id;
                AnimalId = animalId;
                UserId = userId;
                AdoptionRequestDate = adoptionDate;
                State = state;
                Description = description;
            }
            #endregion

       
    }
    public enum AdoptionStateEn
    {
        Pendiente,
        Aprobada,
        Rechazada
    }
}
