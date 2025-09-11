using Domain;
using DTOs;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AuthService
    {
        public UserDTO? Login(UserLoginRequestDTO loginReqDTO)
        {
            UserRepository userRepository = new UserRepository();
            var user = userRepository.Login(loginReqDTO.UserName, loginReqDTO.Password);
            if (user != null)
            {
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

        public bool Register(UserRegisterRequestDTO registerReqDTO)
        {
            UserRepository userRepository = new UserRepository();
            bool exists = userRepository.ExistsByUserName(registerReqDTO.UserName);
            if (exists)
            {
                return false;
            }
            User createdUser =
               new User(Guid.NewGuid().ToString(),
               registerReqDTO.Name,
               registerReqDTO.SurName,
               registerReqDTO.DNI,
               (UserType)Enum.Parse(typeof(UserType), registerReqDTO.UserType),
               registerReqDTO.UserName,
               registerReqDTO.Password);

            userRepository.Add(createdUser);
            return true;
        }
    }
}
