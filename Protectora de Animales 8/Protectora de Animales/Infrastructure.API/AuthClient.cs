using DTOs;
using Infrastructure.API;
using Newtonsoft.Json;

namespace Infrastructure.API
{
    public class AuthClient
    {
        IApiHttpClient _apiHttpClient;
        public AuthClient(IApiHttpClient apiHttpClient)
        {
            _apiHttpClient = apiHttpClient;
        }
        async public Task<UserDTO> LoginAsync(UserLoginRequestDTO userLogin)
        {
            try
            {
                var loginResponse = await _apiHttpClient.PostAsync<UserLoginResponseDTO>(
                    "/auth/login",
                    data: userLogin
                    );
                if (loginResponse != null)
                {
                    if (loginResponse.Success)
                    {
                        return loginResponse.User;
                    }
                    else
                    {
                        throw new Exception($"Login failed: {loginResponse.Message}");
                    }
                }
                throw new Exception("Login failed: No response from server.");
            }
            catch (Exception ex)
            {
                throw new Exception($"LoginAsync Error: {ex.Message}", ex);
            }
        }

        async public Task<UserRegisterResponseDTO> RegisterAsync(UserRegisterRequestDTO userRegister)
        {
            try
            {
                Console.WriteLine("aaaa");
                var registerResponse = await _apiHttpClient.PostAsync<UserRegisterResponseDTO>(
                    "/auth/register",
                    data: userRegister
                    );
                if (registerResponse != null)
                {
                    return registerResponse;
                }
                throw new Exception("Register failed: No response from server.");
            }
            catch (Exception ex)
            {
                throw new Exception($"RegisterAsync Error: {ex.Message}", ex);
            }
        }
    }
}
