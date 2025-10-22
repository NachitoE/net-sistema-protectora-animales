using Domain;
using Domain.History;
using DTOs;
using DTOs.History;
using Helpers;
using Infrastructure.Data;
using static Domain.Animal;

namespace Services
{
    public class AnimalResponsibleHistoriesService
    {
        public AnimalResponsibleHistoryDTO Add(AnimalResponsibleHistoryDTO aRHDTO)
        {
            AnimalResponsibleHistoryRepository animalRHRepository = new AnimalResponsibleHistoryRepository();
            AnimalResponsibleHistory createdAnimalRH = new AnimalResponsibleHistory
            (
                Guid.NewGuid().ToString(),
                aRHDTO.AssignedDate,
                aRHDTO.ResponsibleId,
                aRHDTO.AnimalId
            );

            animalRHRepository.Add(createdAnimalRH);

            aRHDTO.Id = createdAnimalRH.Id;
            return aRHDTO;
        }

        public AnimalResponsibleHistoryDTO? Get(string id)
        {
            var animalRHRepository = new AnimalResponsibleHistoryRepository();
            AnimalResponsibleHistory? animalRH = animalRHRepository.Get(id);

            if (animalRH != null)
            {
                return animalRH.ToDTO();
            }
            return null;
        }

        public bool Delete(string id)
        {
            AnimalResponsibleHistoryRepository animalRepository = new AnimalResponsibleHistoryRepository();
            return animalRepository.Delete(id);
        }

        public List<AnimalResponsibleHistoryDTO> GetAll()
        {
            AnimalResponsibleHistoryRepository animalRepository = new AnimalResponsibleHistoryRepository();
            var animalsDomain = animalRepository.GetAll();
            var allAnimalDTOs = animalsDomain.Select((animal) =>
                animal.ToDTO()
            ).ToList();
            return allAnimalDTOs;
        }

        public List<AnimalResponsibleHistoryDTO> GetByAnimalId(string animalId)
        {
            AnimalResponsibleHistoryRepository animalRHRepository = new AnimalResponsibleHistoryRepository();
            var animalRHsDomain = animalRHRepository.GetByAnimalId(animalId);
            var animalRHsDTOs = animalRHsDomain.Select((animalRH) =>
                animalRH.ToDTO()
            ).ToList();
            return animalRHsDTOs;
        }
    }
}
