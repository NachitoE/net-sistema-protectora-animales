using System;

namespace Shared
{
    public class Sighting : IIdentifiable
    {
        private string _sightingId;
        private string _sightingAddressName;
        private int _sightingAddressNumber;
        private DateTime _sightingDateTime;
        private string _animalId;
        public string Id
        {
            get { return _sightingId; }
            set { _sightingId = value; }
        }
        public string SightingAddressName
        {
            get { return _sightingAddressName; }
            set { _sightingAddressName = value; }
        }
        public int SightingAddressNumber
        {
            get { return _sightingAddressNumber; }
            set { _sightingAddressNumber = value; }
        }
        public DateTime SightingDateTime
        {
            get { return _sightingDateTime; }
            set { _sightingDateTime = value; }
        }
        public string AnimalId
        {
            get { return _animalId; }
            set { _animalId = value; }
        }
    }
}
