using Domain;
using DTOs;
using Infrastructure.Data;
using Helpers;
using static Domain.Animal;

namespace Services
{
    public class AnimalsService
    {
        public AnimalDTO Add(AnimalDTO animalDTO)
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

        public List<AnimalDTO> GetAvailableAnimals()
        {
            return
                GetAll()
                .Where((animalDTO) => animalDTO.AnimalState == EnumConversion.AnimalStateToString(AnimalStateEn.Disponible))
                .ToList();
        }

        public List<AnimalDTO> GetAnimalsBySpecies(string species)
        {
            AnimalRepository animalRepository = new AnimalRepository();
            var animalsDomain = animalRepository.GetAll();
            
            // Parse species string to enum
            if (Enum.TryParse<Animal.SpeciesEn>(species, true, out var speciesEnum))
            {
                var animalsBySpecies = animalsDomain
                    .Where(a => a.Species == speciesEnum && a.AnimalState == Animal.AnimalStateEn.Disponible)
                    .Select(animal => new AnimalDTO
                    {
                        Id = animal.Id,
                        Name = animal.Name,
                        Species = animal.Species.ToString(),
                        BirthDate = animal.BirthDate,
                        UserId = animal.UserId,
                        AnimalState = animal.AnimalState.ToString(),
                        Description = animal.Description
                    }).ToList();
                return animalsBySpecies;
            }
            return new List<AnimalDTO>();
        }

        public List<AnimalDTO> GetAnimalsBelongingToUser(string userId)
        {
            AnimalRepository animalRepository = new AnimalRepository();
            var animalsDomain = animalRepository.GetAll();
            var clientAnimals = animalsDomain
                .Where(a => a.UserId == userId)
                .Select(animal => new AnimalDTO
                {
                    Id = animal.Id,
                    Name = animal.Name,
                    Species = animal.Species.ToString(),
                    BirthDate = animal.BirthDate,
                    UserId = animal.UserId,
                    AnimalState = animal.AnimalState.ToString(),
                    Description = animal.Description
                }).ToList();
            return clientAnimals;
        }

        public AnimalDTO? Update(AnimalDTO animalDTO)
        {
            AnimalRepository animalRepository = new AnimalRepository();

            Animal animalToUpdate = new Animal
            (
                animalDTO.Id,
                animalDTO.Name,
                EnumConversion.StringToSpecies(animalDTO.Species),
                animalDTO.BirthDate,
                animalDTO.UserId,
                EnumConversion.StringToAnimalState(animalDTO.AnimalState),
                animalDTO.Description
            );

            bool updated = animalRepository.Update(animalToUpdate);
            return updated ? animalDTO : null;
        }
        public void SetAnimalAsAvailable(string id)
        {
            var animalRepository = new AnimalRepository();
            Animal? animal = animalRepository.Get(id);

            if (animal != null)
            {
                animal.AnimalState = AnimalStateEn.Disponible;
                animalRepository.Update(animal);
            }
        }
    }
}
