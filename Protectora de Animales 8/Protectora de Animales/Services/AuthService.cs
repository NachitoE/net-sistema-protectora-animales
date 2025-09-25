using Domain;
using DTOs;
using Helpers;
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


        public UserRegisterResponseDTO Register(UserRegisterRequestDTO registerReqDTO)
        {
            UserRepository userRepository = new UserRepository();
            bool exists = userRepository.ExistsByUserName(registerReqDTO.UserName);
            if (exists)
            {
                return new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = "El nombre de usuario ya está en uso"
                };
            }
            UserStatus userStatus = UserStatus.Active;
            // calc status
            if (registerReqDTO.UserType == EnumConversion.UserTypeToString(UserType.Transito))
            {
                userStatus = UserStatus.PendingHouse;
            }
            User createdUser =
               new User(Guid.NewGuid().ToString(),
               registerReqDTO.Name,
               registerReqDTO.SurName,
               registerReqDTO.DNI,
               EnumConversion.StringToUserType(registerReqDTO.UserType),
               registerReqDTO.UserName,
               registerReqDTO.Password,
               userStatus);

            userRepository.Add(createdUser);
            return new UserRegisterResponseDTO
            {
                Success = true,
                Message = "Usuario creado correctamente",
                UserId = createdUser.Id
            };
        }
        /*
          public async Task<UserRegisterResponseDTO> RegisterAsync(UserRegisterRequestDTO request)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/auth/register", request);

            if (!response.IsSuccessStatusCode)
            {
                string errorContent = await response.Content.ReadAsStringAsync();
                return new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = $"Error en API: {response.StatusCode}. Contenido: {errorContent}"
                };
            }

            try
            {
                return await response.Content.ReadFromJsonAsync<UserRegisterResponseDTO>()
                       ?? new UserRegisterResponseDTO
                       {
                           Success = false,
                           Message = "Respuesta vacía desde la API"
                       };
            }
            catch (Exception ex)
            {
                string raw = await response.Content.ReadAsStringAsync();
                return new UserRegisterResponseDTO
                {
                    Success = false,
                    Message = $"Error deserializando: {ex.Message}. Contenido: {raw}"
                };
            }
        } 
        */
    }
}
