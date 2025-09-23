using DTOs.House;

namespace Infrastructure.API.Interfaces
{
    public interface IHouseService
    {
        Task CreateAsync(string userId, HouseRegisterRequestDTO request);
    }
}
