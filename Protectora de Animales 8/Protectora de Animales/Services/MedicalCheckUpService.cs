using Domain;
using DTOs;
using Helpers;
using Infrastructure.Data;

namespace Services
{
    public class MedicalCheckUpService
    {
        public MedicalCheckUpDTO Add(MedicalCheckUpRegisterDTO checkUpRegDTO)
        {
            MedicalCheckUpRepository checkUpRepository = new MedicalCheckUpRepository();
            MedicalCheckUp createdCheckUp = new MedicalCheckUp
            (
                Guid.NewGuid().ToString(),
                checkUpRegDTO.UserId,
                checkUpRegDTO.CheckUpDate,
                checkUpRegDTO.Observation,
                checkUpRegDTO.AnimalId
            );

            checkUpRepository.Add(createdCheckUp);

            return createdCheckUp.ToDTO();
        }

        public MedicalCheckUpDTO? Get(string id)
        {
            var checkUpRepository = new MedicalCheckUpRepository();
            MedicalCheckUp? checkUp = checkUpRepository.Get(id);

            if (checkUp != null)
            {
                return checkUp.ToDTO();
            }
            return null;
        }

        public MedicalCheckUpDTO? Update(string id, MedicalCheckUpDTO dto)
        {
            MedicalCheckUpRepository checkUpRepository = new MedicalCheckUpRepository();
            var checkUp = checkUpRepository.Get(id);
            if (checkUp == null) return null;

            checkUp.UserId = dto.UserId;
            checkUp.CheckUpDate = dto.CheckUpDate;
            checkUp.Observation = dto.Observation;
            checkUp.AnimalId = dto.AnimalId;

            if (checkUpRepository.Update(checkUp))
            {
                return checkUp.ToDTO();
            }
            return null;
        }

        public bool Delete(string id)
        {
            MedicalCheckUpRepository checkUpRepository = new MedicalCheckUpRepository();
            return checkUpRepository.Delete(id);
        }

        public List<MedicalCheckUpDTO> GetAll()
        {
            MedicalCheckUpRepository checkUpRepository = new MedicalCheckUpRepository();
            var checkUpsDomain = checkUpRepository.GetAll();
            var allCheckUpDTOs = checkUpsDomain.Select(checkUp => checkUp.ToDTO()).ToList();
            return allCheckUpDTOs;
        }

        public List<MedicalCheckUpDTO> GetByAnimalId(string animalId)
        {
            MedicalCheckUpRepository checkUpRepository = new MedicalCheckUpRepository();
            var allCheckUps = checkUpRepository.GetAll();
            var checkUpsByAnimal = allCheckUps
                .Where(c => c.AnimalId == animalId)
                .Select(c => c.ToDTO())
                .ToList();
            return checkUpsByAnimal;
        }

        public List<MedicalCheckUpDTO> GetByUserId(string userId)
        {
            MedicalCheckUpRepository checkUpRepository = new MedicalCheckUpRepository();
            var allCheckUps = checkUpRepository.GetAll();
            var checkUpsByUser = allCheckUps
                .Where(c => c.UserId == userId)
                .Select(c => c.ToDTO())
                .ToList();
            return checkUpsByUser;
        }
    }
}
