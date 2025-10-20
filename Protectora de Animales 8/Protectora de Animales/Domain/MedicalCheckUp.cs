using System;

namespace Domain
{
    public class MedicalCheckUp
    {
        #region Fields/Properties
        private string _id;
        private DateTime _checkUpDate;
        private string _observation;
        private string _animalId;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime CheckUpDate
        {
            get { return _checkUpDate; }
            set { _checkUpDate = value; }
        }

        public string Observation
        {
            get { return _observation; }
            set { _observation = value; }
        }
        public string AnimalId
        {
            get { return _animalId; }
            set { _animalId = value; }
        }

        private User? _user;

        public Animal Animal
        {
            get => _animal;
            set => _animal = value;
        }

        private Animal? _animal;
        #endregion

        #region Constructor
        public MedicalCheckUp(string id, DateTime checkUpDate, string observation, string animalId)
        {
            Id = id;
            CheckUpDate = checkUpDate;
            Observation = observation;
            AnimalId = animalId;
        }
        #endregion
    }
}
