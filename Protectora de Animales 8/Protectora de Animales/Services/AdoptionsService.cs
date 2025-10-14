using Domain;
using DTOs;
using Helpers;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Animal;

namespace Services
{
    public class AdoptionsService
    {
        public AdoptionDTO Add(AdoptionRequestDTO adoptionReqDTO)
        {
            AdoptionRepository adoptionRepository = new AdoptionRepository();
            Adoption createdAdoption = new Adoption
            (
                Guid.NewGuid().ToString(),
                adoptionReqDTO.AnimalId,
                adoptionReqDTO.UserId,
                adoptionReqDTO.AdoptionRequestDate,
                AdoptionStateEn.Pendiente,
                adoptionReqDTO.Description
            );

            adoptionRepository.Add(createdAdoption);

            return createdAdoption.ToDTO();
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
    }
}
