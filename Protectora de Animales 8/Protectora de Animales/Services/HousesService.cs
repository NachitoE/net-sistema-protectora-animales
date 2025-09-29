using Domain;
using DTOs;
using DTOs.House;
using Helpers;
using Infrastructure.Data;

namespace Services
{
    public class HousesService
    {
        public HouseDTO Add(HouseRegisterRequestDTO houseRegDTO)
        {
            HouseRepository houseRepository = new HouseRepository();
            House createdHouse = new House
            (
                Guid.NewGuid().ToString(),
                houseRegDTO.UserId,
                houseRegDTO.Address,
                houseRegDTO.AddressNumber,
                houseRegDTO.Capacity
            );
            new UsersService().ActivateUser(houseRegDTO.UserId);
            houseRepository.Add(createdHouse);

            return new HouseDTO()
            {
                Id = createdHouse.Id,
                UserId = createdHouse.UserId,
                Address = createdHouse.Address,
                AddressNumber = createdHouse.AddressNumber,
                Capacity = createdHouse.Capacity
            };
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
            if (houseRepository.Delete(id))
            {
                // set user as pending house, set current user animals as available
                var userDTO = GetUserBelongingToHouse(id);
                if (userDTO == null)
                    return false;
                AnimalsService animalsService = new AnimalsService();
                var animals = animalsService.GetAnimalsBelongingToUser(userDTO.Id);
                foreach(AnimalDTO animal in animals)
                {
                    animalsService.SetAnimalAsAvailable(animal.Id);
                }
                return true;
            }
            return false;
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
        public UserDTO? GetUserBelongingToHouse(string houseId)
        {
            var house = Get(houseId);
            if (house == null) return null;
            var userService = new UsersService();
            return userService.Get(house.UserId);
        }
        public bool HasHouse(string userId)
        {
            var filteredHouseDTOs = GetAll()
                .Where((h) => h.UserId == userId)
                .ToList();
            return filteredHouseDTOs.Count > 0;
        }

        public HouseBaseResponseDTO ChangeCapacity(HouseChangeCapacityDTO changeCapacityDTO)
        {
            var userService = new UsersService();
            var houseRepository = new HouseRepository();
            var house = houseRepository.Get(changeCapacityDTO.HouseId);
            
            if (house == null)
            {
                return new HouseBaseResponseDTO()
                {
                    Message = "Casa no encontrada",
                    Success = false
                };
            }
            UserDTO? houseUserDTO = userService.Get(house.UserId);
            if (houseUserDTO == null)
            {
                return new HouseBaseResponseDTO()
                {
                    Message = "El usuario asignado a esa casa no fue encontrado",
                    Success = false
                };
            }
            if (changeCapacityDTO.NewCapacity < 0)
            {
                return new HouseBaseResponseDTO()
                {
                    Message = "La capacidad no puede ser negativa",
                    Success = false
                };
            }
            int currentAnimalsAmountInHouse = house.Capacity - userService.GetUserRemainingCapacity(houseUserDTO).RemainingCapacity;
            if (changeCapacityDTO.NewCapacity < currentAnimalsAmountInHouse)
            {
                return new HouseBaseResponseDTO()
                {
                    Message = "La nueva capacidad no puede ser menor que la cantidad de animales actuales",
                    Success = false
                };
            }
            house.Capacity = changeCapacityDTO.NewCapacity;
            houseRepository.Update(house);
            return new HouseBaseResponseDTO()
            {
                Message = "Capacidad actualizada con éxito",
                Success = true
            };
        }
    }
}

