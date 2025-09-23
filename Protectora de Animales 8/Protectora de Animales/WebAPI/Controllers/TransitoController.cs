using DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Services;
using Infrastructure.API.Interfaces;



namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/transito")]
    public class TransitoController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IHouseService _houseService;

        public TransitoController(IUserService userService, IHouseService houseService)
        {
            _userService = userService;
            _houseService = houseService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] TransitoRegisterWithHouseDTO dto)
        {
            using var tx = await _userService.BeginTransactionAsync();

            var userId = await _userService.CreateTransitoAsync(new TransitoRegisterRequestDTO
            {
                Name = dto.Name,
                SurName = dto.SurName,
                DNI = dto.DNI,
                UserName = dto.UserName,
                Password = dto.Password
            });

            await _houseService.CreateAsync(userId, new DTOs.House.HouseRegisterRequestDTO
            {
                Address = dto.Address,
                AddressNumber = dto.AddressNumber,
                Capacity = dto.Capacity
            });

            return Ok(new { Success = true, Message = "Transito y casa registrados." });
        }
    }

    public class TransitoRegisterWithHouseDTO : TransitoRegisterRequestDTO
    {
        public string Address { get; set; }
        public int AddressNumber { get; set; }
        public int Capacity { get; set; }
    }
}

