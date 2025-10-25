using Domain;
using DTOs;
using DTOs.User;
using Helpers;
using Infrastructure.Data;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;

namespace Services
{
    public class UsersService
    {
        //Note to self: still need to add Update and Delete methods

        // Question: should we make a register method or use Add for every time a user is created?
        /*
        public UserDTO Add(UserDTO userDTO) 
        {
            UserRepository userRepository = new UserRepository();
            
            User createdUser = 
                new User(Guid.NewGuid().ToString(), userDTO.Name, userDTO.SurName, userDTO.DNI, (UserType)Enum.Parse(typeof(UserType), userDTO.UserType), userDTO.UserName, "temporarypassword", userStatus);

            userRepository.Add(createdUser);
            
            userDTO.Id = createdUser.Id;

            return userDTO;
        }
        */
        public UserDTO? Get(string id)
        {
            var userRepository = new UserRepository();
            User? user = userRepository.Get(id);

            if (user != null) { 
                var strUserType = user.UserType.ToString();
                return user.ToDTO();
            }
            return null;
        }

        public bool Delete(string id) 
        {
            UserRepository userRepository = new UserRepository();
            try
            {
                if(userRepository.Get(id).UserType == UserType.Admin)
                {
                    throw new DomainException("No se puede eliminar a un usuario administrador.");
                }
                bool deleted = userRepository.Delete(id);
                return deleted;
            }
            catch (Exception)
            {
                throw new DomainException("No se puede eliminar a este usuario.");
            }
        }

        public List<UserDTO> GetAll()
        {
            UserRepository userRepository = new UserRepository();
            var usersDomain = userRepository.GetAll();
            var allUsersDTOs = usersDomain.Select((user) => user.ToDTO()).ToList();
            return allUsersDTOs;
        }

        public List<UserDTO> GetByCriteria(UserDTO criteria)
        {
            UserRepository userRepository = new UserRepository();
            List<User> filteredUsers = userRepository.FilterByCriteria(
                criteria.Name,
                criteria.SurName,
                criteria.DNI,
                criteria.UserType,
                criteria.UserName
                );

            return filteredUsers.Select(fUser => fUser.ToDTO()).ToList();
        }
        public List<UserDTO> GetAvailableToAdopt()
        {
            var availableUsers = GetAll()
                .Where(u => (u.UserType == EnumConversion.UserTypeToString(UserType.Voluntario)
                            || u.UserType == EnumConversion.UserTypeToString(UserType.Transito)) &&
                            GetUserRemainingCapacity(u).RemainingCapacity > 0)
                .ToList();

            return availableUsers;
        }
        
        public UserRemainingCapacityResponseDTO GetUserRemainingCapacity(UserDTO userDTO)
        {
            HousesService housesService = new HousesService();
            AnimalsService animalsService = new AnimalsService();
            if (userDTO.UserType == EnumConversion.UserTypeToString(UserType.Voluntario))
            {
                int userAnimalsCount = new AnimalsService().GetAnimalsBelongingToUser(userDTO.Id).Count;
                return new UserRemainingCapacityResponseDTO()
                {
                    RemainingCapacity = User.MAX_CAPACITY_VOLUNTARIOS - userAnimalsCount,
                    User = userDTO,
                    Success = true
                };
            }
            else if (userDTO.UserType == EnumConversion.UserTypeToString(UserType.Transito))
            {
                var house = housesService.GetHouseBelongingToUser(userDTO.Id);
                if (house == null)
                    return new UserRemainingCapacityResponseDTO()
                    {
                        RemainingCapacity = 0,
                        User = userDTO,
                        Success = false,
                        Message = "El usuario no tiene una casa asignada"
                    };

                return new UserRemainingCapacityResponseDTO()
                {
                    RemainingCapacity = house.Capacity - animalsService.GetAnimalsBelongingToUser(userDTO.Id).Count,
                    User = userDTO,
                    Success = true,
                };
            }
            return new UserRemainingCapacityResponseDTO()
            {
                RemainingCapacity = 0,
                User = userDTO,
                Success = false,
                Message = "El usuario no es ni voluntario ni tránsito"
            };
        }

        public UserRemainingCapacityResponseDTO GetUserRemainingCapacity(string userId)
        {
            var userDTO = Get(userId);
            if (userDTO == null)
                return new UserRemainingCapacityResponseDTO()
                {
                    RemainingCapacity = 0,
                    User = null,
                    Success = false,
                    Message = "El usuario no existe"
                }; ;
            return GetUserRemainingCapacity(userDTO);
        }

        public UserDTO? ModifyUser(string id, UserDTO userDTO)
        {
            UserRepository userRepository = new UserRepository();
            User? user = userRepository.Get(id);
            if (user != null)
            {
                user.Name = string.IsNullOrEmpty(userDTO.Name) ? user.Name : userDTO.Name;
                user.SurName = string.IsNullOrEmpty(userDTO.SurName) ? user.SurName : userDTO.SurName;
                user.Dni = string.IsNullOrEmpty(userDTO.DNI) ? user.Dni : userDTO.DNI;
                user.UserType = string.IsNullOrEmpty(userDTO.UserType) ? user.UserType : EnumConversion.StringToUserType(userDTO.UserType);
                user.UserName = string.IsNullOrEmpty(userDTO.UserName) ? user.UserName : userDTO.UserName;
                
                userRepository.Update(user);
                return user.ToDTO();
            }
            return null;
        }
        public void DeactivateUser(string id)
        {
            ChangeUserStatus(id, UserStatus.Inactive);
        }

        public void ActivateUser(string id)
        {
            ChangeUserStatus(id, UserStatus.Active);
        }

        public void SetUserPendingHouse(string id)
        {
            ChangeUserStatus(id, UserStatus.PendingHouse);
        }

        private void ChangeUserStatus(string id, UserStatus newStatus)
        {
            UserRepository userRepository = new UserRepository();
            User? user = userRepository.Get(id);
            if (user != null)
            {
                user.UserStatus = newStatus;
                userRepository.Update(user);
            }
        }
    }
    /*
     *  public bool IsValidUser(string userName, string password)
    {
        foreach (User user in GetAll())
        {
            if (user.UserName == userName && user.Password == password) return true;
        }
        return false;
    }
    public bool UserNameExists(string userName)
    {
        foreach (User user in GetAll())
        {
            if (user.UserName == userName) return true;
        }
        return false;
    }



    public User GetByUserName(string userName)
    {
        return GetAll().FirstOrDefault(u => u.UserName == userName);
    }
    public void SetCurrentLoggedOnUser(User user)
    {
        _currentLoggedOnUser = user;
    }
    */
}

