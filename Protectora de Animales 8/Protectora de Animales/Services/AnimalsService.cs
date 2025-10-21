using Domain;
using DTOs;
using Infrastructure.Data;
using Helpers;
using static Domain.Animal;
using DTOs.History;

namespace Services
{
    public class AnimalsService
    {
        public AnimalDTO Add(AnimalDTO animalDTO)
        {
            if (string.IsNullOrEmpty(animalDTO.AnimalState))
            {
                animalDTO.AnimalState = EnumConversion.AnimalStateToString(AnimalStateEn.Disponible);
            }
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
            Animal? existingAnimal = animalRepository.Get(animalDTO.Id);
            
            if (existingAnimal == null)
            {
                return null; // Animal no encontrado
            }

            // Validaciones de datos
            if (!IsValidAnimalData(animalDTO, existingAnimal))
            {
                return null;
            }

            // Actualización parcial - solo cambiar campos que no están vacíos
            existingAnimal.Name = string.IsNullOrEmpty(animalDTO.Name) ? existingAnimal.Name : animalDTO.Name;
            existingAnimal.Description = string.IsNullOrEmpty(animalDTO.Description) ? existingAnimal.Description : animalDTO.Description;
            
            // Para BirthDate, verificar si es una fecha válida diferente del valor por defecto
            if (animalDTO.BirthDate != default(DateTime) && animalDTO.BirthDate != existingAnimal.BirthDate)
            {
                existingAnimal.BirthDate = animalDTO.BirthDate;
            }

            // Species y AnimalState solo si no están vacíos y son válidos
            if (!string.IsNullOrEmpty(animalDTO.Species))
            {
                existingAnimal.Species = EnumConversion.StringToSpecies(animalDTO.Species);
            }
            
            if (!string.IsNullOrEmpty(animalDTO.AnimalState))
            {
                existingAnimal.AnimalState = EnumConversion.StringToAnimalState(animalDTO.AnimalState);
            }

            // UserId puede ser null/vacío intencionalmente
            if (animalDTO.UserId != null)
            {
                existingAnimal.UserId = string.IsNullOrEmpty(animalDTO.UserId) ? null : animalDTO.UserId;
            }

            bool updated = animalRepository.Update(existingAnimal);
            return updated ? existingAnimal.ToDTO() : null;
        }

        private bool IsValidAnimalData(AnimalDTO animalDTO, Animal existingAnimal)
        {
            // Validar ID
            if (string.IsNullOrEmpty(animalDTO.Id))
            {
                return false;
            }

            // Validar nombre si se está proporcionando
            if (!string.IsNullOrEmpty(animalDTO.Name) && animalDTO.Name.Trim().Length == 0)
            {
                return false;
            }

            // Validar fecha de nacimiento si se está proporcionando
            if (animalDTO.BirthDate != default(DateTime))
            {
                // No puede ser fecha futura
                if (animalDTO.BirthDate > DateTime.Now)
                {
                    return false;
                }
                
                // No puede ser muy antigua (antes de 1980)
                if (animalDTO.BirthDate < new DateTime(1980, 1, 1))
                {
                    return false;
                }
            }

            // Validar especies si se está proporcionando
            if (!string.IsNullOrEmpty(animalDTO.Species))
            {
                if (!Enum.TryParse<Animal.SpeciesEn>(animalDTO.Species, true, out _))
                {
                    return false;
                }
            }

            // Validar estado del animal si se está proporcionando
            if (!string.IsNullOrEmpty(animalDTO.AnimalState))
            {
                if (!Enum.TryParse<Animal.AnimalStateEn>(animalDTO.AnimalState, true, out _))
                {
                    return false;
                }
            }

            // Validar descripción si se está proporcionando
            if (!string.IsNullOrEmpty(animalDTO.Description) && animalDTO.Description.Trim().Length == 0)
            {
                return false;
            }

            return true;
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

        public AnimalDTO? AssignResponsible(string id, string userId)
        {
            var animalRepository = new AnimalRepository();
            var userService = new UsersService();
            var existingUser = userService.Get(userId); // Verifica que el usuario exista, lanza excepción si no
            if(existingUser == null)
            {
                throw new DomainException("userId no pertenece a un usuario existente");
            }
            Animal? animal = animalRepository.Get(id);
            if (animal != null)
            {
                animal.UserId = userId;
                animal.AnimalState = AnimalStateEn.Adoptado;
                animalRepository.Update(animal);

                // rechazar adopciones pendientes para ese animal
                var adoptionServ = new AdoptionsService();
                adoptionServ.RejectPendingAdoptionsByAnimalId(animal.Id);

                // crear historial
                var animalRHService = new AnimalResponsibleHistoriesService();
                animalRHService.Add(new AnimalResponsibleHistoryDTO
                {
                    AnimalId = animal.Id,
                    ResponsibleId = userId,
                    AssignedDate = DateTime.Now
                });

                return animal.ToDTO();
            }
            throw new DomainException("id no pertenece a un animal existente");
        }

        public List<AnimalDTO> GetByCriteria(AnimalDTO criteria)
        {
            AnimalRepository animalRepository = new AnimalRepository();
            List<Animal> filteredAnimals = animalRepository.FilterByCriteria(
                criteria.Name,
                criteria.Species,
                criteria.Description,
                criteria.AnimalState,
                criteria.UserId
                );

            return filteredAnimals.Select(fUser => fUser.ToDTO()).ToList();
        }
    }
}
