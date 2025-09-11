using Domain;
using DTOs;
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
                new User(Guid.NewGuid().ToString(), userDTO.Name, userDTO.SurName, userDTO.DNI, userDTO.UserType, userDTO.UserName, "temporarypassword");

            userRepository.Add(createdUser);
            
            userDTO.Id = createdUser.Id;

            return userDTO;
        }

        public UserDTO? Get(int id)
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
                    DNI = user.DNI,
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
            var usersDomain = new List<User>();//get from db
            var allUsersDTOs = usersDomain.Select((user) => new UserDTO
            {
                Id = user.Id,
                Name = user.Name,
                SurName = user.SurName,
                DNI = user.DNI,
                UserType = user.UserType.ToString(),
                UserName = user.UserName
            }).ToList();
            return allUsersDTOs;
        }

        public List<UserDTO> GetByCriteria(string criteria)
        {
            //var clienteRepository = new ClienteRepository();

            // Mapear DTO a Domain Model
            //var criteria = new ClienteCriteria(criteriaDTO.Texto);

            // Llamar al repositorio
            //var clientes = clienteRepository.GetByCriteria(criteria);

            // Mapear Domain Model a DTO
            /*
            return clientes.Select(c => new ClienteDTO
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Email = c.Email,
                PaisId = c.PaisId,
                PaisNombre = c.Pais?.Nombre,
                FechaAlta = c.FechaAlta
            });
            */
            return new List<UserDTO>();
        }
    }
}
