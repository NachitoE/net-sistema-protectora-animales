using DTOs.User;

namespace Infrastructure.API.Interfaces
{
    public interface IUserService
    {
        Task<string> CreateTransitoAsync(TransitoRegisterRequestDTO request);
        Task<IDisposable> BeginTransactionAsync();
    }
}