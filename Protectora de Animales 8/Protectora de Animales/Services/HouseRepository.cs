using Domain;
using DTOs;
using Helpers;
using Infrastructure.Data;

namespace Services
{
    public class HouseRepository
    {
        public HouseDTO Add(HouseDTO animalDTO)
        {
            AnimalRepository animalRepository = new AnimalRepository();
            Animal createdAnimal = new Animal
            (
                Guid.NewGuid().ToString(),
                animalDTO.Name,
                EnumConversion.StringToSpecies(animalDTO.Species),
                animalDTO.BirthDate,
                animalDTO.UserId,
                EnumConversion.StringToAnimalState(animalDTO.AnimalState),
                animalDTO.Description
            );

            animalRepository.Add(createdAnimal);

            animalDTO.Id = createdAnimal.Id;

            return animalDTO;
        }

        public AnimalDTO? Get(string id)
        {
            var animalRepository = new AnimalRepository();
            Animal? animal = animalRepository.Get(id);

            if (animal != null)
            {
                return animal.ToDTO();
            }
            return null;
        }

        public bool Delete(string id)
        {
            AnimalRepository animalRepository = new AnimalRepository();
            return animalRepository.Delete(id);
        }

        public List<AnimalDTO> GetAll()
        {
            AnimalRepository animalRepository = new AnimalRepository();
            var animalsDomain = animalRepository.GetAll();
            var allAnimalDTOs = animalsDomain.Select((animal) =>
                animal.ToDTO()
            ).ToList();
            return allAnimalDTOs;
        }
    }
}
