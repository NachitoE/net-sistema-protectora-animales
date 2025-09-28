using System;

namespace Domain
{ 
    public class Sighting
    {
        #region Fields/Properties
        private string _sightingId;
        private string _sightingAddressName;
        private string _sightingAddressNumber;
        private DateTime _sightingDateTime;
        private string _sightingDescription;
        private SightingState _sightingState; 

        public string Id
        {
            get => _sightingId;
            set => _sightingId = value;
        }
        public string SightingAddressName
        {
            get => _sightingAddressName; 
            set => _sightingAddressName = value;
        }
        public string SightingAddressNumber
        {
            get => _sightingAddressNumber;
            set => _sightingAddressNumber = value; 
        }
        public DateTime SightingDateTime
        {
            get => _sightingDateTime;
            set => _sightingDateTime = value; 
        }

        public string SightingDescription
        {
            get => _sightingDescription; 
            set => _sightingDescription = value ;
        }
        public SightingState Sightingstate
        {
            get => _sightingState; 
            set => _sightingState = value;
        }
        #endregion
        public Sighting() { }
        public Sighting(string id, string Adressname, string Adressnumber, DateTime Sightingdate, string Description, SightingState state= SightingState.Nuevo)
        {
            _sightingId = id;
            _sightingAddressName = Adressname;
            _sightingAddressNumber = Adressnumber;
            _sightingDateTime = Sightingdate;
            _sightingDescription = Description;
            _sightingState = state;
        }

        public enum SightingState
        {
            Nuevo, Atendido, Eliminado
        }
    }
}
