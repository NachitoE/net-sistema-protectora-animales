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

        public HouseDTO? Modify(string id, HouseDTO dto)
        {
            HouseRepository houseRepository = new HouseRepository();
            var house = houseRepository.Get(id);
            if (house == null) return null;
            house.Address = dto.Address;
            house.AddressNumber = dto.AddressNumber;
            house.Capacity = dto.Capacity;
            if (houseRepository.Update(house))
            {
                return house.ToDTO();
            }
            return null;
        }
        public bool Delete(string id)
        {
            HouseRepository houseRepository = new HouseRepository();
            var userDTO = GetUserBelongingToHouse(id);
            if (houseRepository.Delete(id))
            {
                // set user as pending house, set current user animals as available
                
                if (userDTO != null)
                {
                    UsersService usersService = new UsersService();
                    usersService.SetUserPendingHouse(userDTO.Id);
                    AnimalsService animalsService = new AnimalsService();
                    var animals = animalsService.GetAnimalsBelongingToUser(userDTO.Id);
                    foreach (AnimalDTO animal in animals)
                    {
                        animalsService.SetAnimalAsAvailable(animal.Id);
                    }
                }
                
                return true;
            }
            throw new Exception("Casa no encontrada");
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
                HouseId = house.Id,
                Message = "Capacidad actualizada con éxito",
                Success = true
            };
        }

        public HouseBaseResponseDTO ChangeAddress(HouseChangeAddressDTO changeAddressDTO)
        {
            var houseRepository = new HouseRepository();
            var house = houseRepository.Get(changeAddressDTO.HouseId);

            if (house == null)
            {
                return new HouseBaseResponseDTO()
                {
                    Message = "Casa no encontrada",
                    Success = false
                };
            }

            var userService = new UsersService();
            UserDTO? houseUserDTO = userService.Get(house.UserId);

            if (houseUserDTO == null)
            {
                return new HouseBaseResponseDTO()
                {
                    Message = "El usuario asignado a esa casa no fue encontrado",
                    Success = false
                };
            }

            if (houseUserDTO.UserType != EnumConversion.UserTypeToString(Domain.UserType.Transito))
            {
                return new HouseBaseResponseDTO()
                {
                    Message = "Solo usuarios de tipo Tránsito pueden cambiar la dirección de su casa",
                    Success = false
                };
            }

            if (string.IsNullOrWhiteSpace(changeAddressDTO.NewAddress))
            {
                return new HouseBaseResponseDTO()
                {
                    Message = "La dirección no puede estar vacía",
                    Success = false
                };
            }
            if (changeAddressDTO.NewAddressNumber <= 0)
            {
                return new HouseBaseResponseDTO()
                {
                    Message = "El número de dirección debe ser mayor a 0",
                    Success = false
                };
            }

            house.Address = changeAddressDTO.NewAddress;
            house.AddressNumber = changeAddressDTO.NewAddressNumber;
            houseRepository.Update(house);

            return new HouseBaseResponseDTO()
            {
                HouseId = house.Id,
                Message = "Dirección actualizada con éxito",
                Success = true
            };
        }
    }
}

