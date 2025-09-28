using Domain;
using DTOs;
using DTOs.Sighting;

namespace Helpers
{
    public static class DTODomainConversion
    {
        public static UserDTO ToDTO(this User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                Name = user.Name,
                SurName = user.SurName,
                DNI = user.Dni,
                UserName = user.UserName,
                UserType = EnumConversion.UserTypeToString(user.UserType)
            };
        }
        /*
          //Domain should be get from the repository, not converted from DTO
        public static Animal ToDomain(this AnimalDTO animalDTO)
        {
            return new Animal
            (
                animalDTO.Id,
                animalDTO.Name,
                EnumConversion.StringToSpecies(animalDTO.Species),
                animalDTO.BirthDate,
                animalDTO.UserId,
                EnumConversion.StringToAnimalState(animalDTO.AnimalState),
                animalDTO.Description
            );
        }
        */
        public static AnimalDTO ToDTO(this Animal animal)
        {
            return new AnimalDTO
            {
                Id = animal.Id,
                Name = animal.Name,
                Species = EnumConversion.SpeciesToString(animal.Species),
                BirthDate = animal.BirthDate,
                UserId = animal.UserId,
                AnimalState = EnumConversion.AnimalStateToString(animal.AnimalState),
                Description = animal.Description
            };
        }

        public static HouseDTO ToDTO(this House house)
        {
            return new HouseDTO
            {
                Id = house.Id,
                UserId = house.UserId,
                Address = house.Address,
                AddressNumber = house.AddressNumber,
                Capacity = house.Capacity
            };
        }

        public static SightingDTO ToDTO(this Sighting sighting)
        {
            return new SightingDTO
            {
                Id = sighting.Id,
                SightingAdressName = sighting.SightingAddressName,
                SightingAdressNumber = sighting.SightingAddressNumber,
                SightingDatetime = sighting.SightingDateTime,
                SightingDescription = sighting.SightingDescription,
                SightingState = Helpers.EnumConversion.SightingStateToString(sighting.Sightingstate)
            };
        } 
    }
}
