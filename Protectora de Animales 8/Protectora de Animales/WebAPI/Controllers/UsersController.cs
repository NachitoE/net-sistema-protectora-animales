using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController
    {
        [HttpGet(Name = "GetAllUsers")]
        public IEnumerable<UserDTO> GetAll()
        {
            return new List<UserDTO>
            {
                new UserDTO
                {
                    Id = "1",
                    Name = "John",
                    SurName = "Doe",
                },
                new UserDTO
                {
                    Id = "2",
                    Name = "Pepe",
                    SurName = "Pepito",
                }
            };
        }

    }
}
