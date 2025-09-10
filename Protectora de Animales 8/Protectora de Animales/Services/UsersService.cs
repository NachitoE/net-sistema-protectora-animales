using Domain;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UsersService
    {

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
