using Domain;
using DTOs;
using Helpers;
using Infrastructure.Data;

namespace Services
{
    public class UsersService
    {
        //Note to self: still need to add Update and Delete methods

        // Question: should we make a register method or use Add for every time a user is created?
        public UserDTO Add(UserDTO userDTO) 
        {
            UserRepository userRepository = new UserRepository();
            User createdUser = 
                new User(Guid.NewGuid().ToString(), userDTO.Name, userDTO.SurName, userDTO.DNI, (UserType)Enum.Parse(typeof(UserType), userDTO.UserType), userDTO.UserName, "temporarypassword");

            userRepository.Add(createdUser);
            
            userDTO.Id = createdUser.Id;

            return userDTO;
        }

        public UserDTO? Get(string id)
        {
            var userRepository = new UserRepository();
            User? user = userRepository.Get(id);

            if (user != null) { 
                var strUserType = user.UserType.ToString();
                return new UserDTO
                {
                    Id = user.Id,
                    Name = user.Name,
                    SurName = user.SurName,
                    DNI = user.Dni,
                    UserType = strUserType,
                    UserName = user.UserName,
                };
            }
            return null;
        }

        public bool Delete(string id) 
        {
            UserRepository userRepository = new UserRepository();
            return userRepository.Delete(id);
        }

        public List<UserDTO> GetAll()
        {
            UserRepository userRepository = new UserRepository();
            var usersDomain = userRepository.GetAll();
            var allUsersDTOs = usersDomain.Select((user) => new UserDTO
            {
                Id = user.Id,
                Name = user.Name,
                SurName = user.SurName,
                DNI = user.Dni,
                UserType = user.UserType.ToString(),
                UserName = user.UserName
            }).ToList();
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

        public List<UserDTO> GetAvailableToAdopt(UserDTO criteria)
        {
            UserService.Instance.GetAll()
                .Where(u => (u.UserType == User.Type.Voluntario
                            || u.UserType == User.Type.Transito) &&
                            UserService.GetUserRemainingCapacity(u) > 0)
                .ToList();
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

       /* public static int GetUserRemainingCapacity(UserDTO userDTO)
        {
            if (userDTO.UserType == EnumConversion.UserTypeToString(UserType.Voluntario))
            {
                int userAnimalsCount = new AnimalsService().GetAnimalsBelongingToUser(userDTO.Id).Count;
                return User.MAX_CAPACITY_VOLUNTARIOS - userAnimalsCount;
            }
            else if (userDTO.UserType == EnumConversion.UserTypeToString(UserType.Transito))
            {
                var house = HouseService.Instance.GetAll().FirstOrDefault(h => h.UserId == userDTO.Id);
                if (house == null)
                    return 0; // No house found for the user

                return house.Capacity -
                    AnimalService.Instance.GetAll().Count(a => a.UserId == userDTO.Id);
            }
            return 0;
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
}
