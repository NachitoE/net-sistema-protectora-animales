using System;

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
        public SpeciesEn Species
        {
            get
            {
                return _specie;
            }
            set
            {
                _specie = value;
            }
        }
        private SpeciesEn _specie;
        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }
        private DateTime _birthDate;

      
        public string UserId
        {
            get => _userId;
            set => _userId = value;
        }
        private string _userId; //owner, caretaker


        public AnimalStateEn AnimalState
        {
            get => _animalState;
            set => _animalState = value;
        }

        private AnimalStateEn _animalState;

        public enum AnimalStateEn
        {
            Adoptado, 
            Disponible
        } 

        private string _description;

        public string Description
        {
            get => _description;
            set => _description = value;
        }
        public Animal(string id, string name, SpeciesEn species, DateTime birthDate, string userId, AnimalStateEn animalState,string desc)
        {
            Id = id;
            Name = name;
            Species = species;
            BirthDate = birthDate;
            UserId = userId;
            AnimalState = animalState;
            Description = desc;
        }

        public enum SpeciesEn
        {
            Perro,
            Gato,
            Conejo,
            Pajaro
        }
        #endregion
    }
}
