using DTOs;
using Infrastructure.API.Interfaces;
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
                    data: JsonConvert.SerializeObject(userLogin)
                    );
                if (loginResponse != null)
                {
                    if(loginResponse.Success)
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
            catch(Exception ex)
            {
                throw new Exception($"LoginAsync Error: {ex.Message}", ex);
            }
        }

        async public Task<bool> RegisterAsync(UserRegisterRequestDTO userRegister)
        {
            try
            {
                var registerResponse = await _apiHttpClient.PostAsync<UserLoginResponseDTO>(
                    "/auth/register",
                    data: JsonConvert.SerializeObject(userRegister)
                    );
                if (registerResponse != null)
                {
                    if (registerResponse.Success)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception($"Register failed: {registerResponse.Message}");
                    }
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
