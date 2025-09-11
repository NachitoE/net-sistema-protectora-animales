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
                    DNI = user.DNI,
                    UserType = strUserType,
                    UserName = user.UserName,
                };
            }
            return null;
        }
    }
}
