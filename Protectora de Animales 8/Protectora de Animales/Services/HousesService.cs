using Domain;
using DTOs;
using DTOs.House;
using Helpers;
using Infrastructure.Data;

namespace Services
{
    public class HousesService
    {
        public HouseDTO Add(HouseDTO houseDTO)
        {
            HouseRepository houseRepository = new HouseRepository();
            House createdHouse = new House
            (
                Guid.NewGuid().ToString(),
                houseDTO.UserId,
                houseDTO.Address,
                houseDTO.AddressNumber,
                houseDTO.Capacity
            );

            houseRepository.Add(createdHouse);

            houseDTO.Id = createdHouse.Id;

            return houseDTO;
        }

        public HouseDTO? Get(string id)
        {
            var houseRepository = new HouseRepository();
            House? house = houseRepository.Get(id);

            if (house != null)
            {
                return house.ToDTO();
            }
            return null;
        }

        public bool Delete(string id)
        {
            HouseRepository houseRepository = new HouseRepository();
            return houseRepository.Delete(id);
        }

        public List<HouseDTO> GetAll()
        {
            HouseRepository houseRepository = new HouseRepository();
            var housesDomain = houseRepository.GetAll();
            var allHouseDTOs = housesDomain.Select((house) =>
                house.ToDTO()
            ).ToList();
            return allHouseDTOs;
        }

        public HouseDTO? GetHouseBelongingToUser(string userId)
        {
            var filteredHouseDTOs = GetAll()
                .Where((h) => h.UserId == userId)
                .ToList();
            return filteredHouseDTOs.FirstOrDefault();

        }

        public async Task CreateAsync(string userId, HouseRegisterRequestDTO request)
        {
            House house = new House(
                null, // El id se deja nulo para que lo genere la API
                userId,
                request.Address,
                request.AddressNumber,
                request.Capacity
            );

            var houseRepo = new HouseRepository();
            houseRepo.Add(house);
        }
    }
}

