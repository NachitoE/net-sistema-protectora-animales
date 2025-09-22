using Domain;
using DTOs;
using Infrastructure.Data;
using System;


namespace Services
{
    public class AuthService
    {
        public UserLoginResponseDTO Login(UserLoginRequestDTO loginReqDTO)
        {
            UserRepository userRepository = new UserRepository();
            var user = userRepository.Login(loginReqDTO.UserName, loginReqDTO.Password);

            if (user == null)
            {
                return new UserLoginResponseDTO
                {
                    Success = false,
                    Message = "Usuario o contraseña incorrectos"
                };
            }

            return new UserLoginResponseDTO
            {
                Success = true,
                Message = "Login exitoso",
                User = new UserDTO
                {
                    Id = user.Id,
                    Name = user.Name,
                    SurName = user.SurName,
                    DNI = user.Dni,
                    UserType = user.UserType.ToString(),
                    UserName = user.UserName
                    // no incluimos la contraseña por seguridad
                }
            };
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
