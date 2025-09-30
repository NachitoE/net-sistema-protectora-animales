using DTOs;

namespace Infrastructure.API
{
    public class AuthClient
    {
        IApiHttpClient _apiHttpClient;
        public AuthClient(IApiHttpClient apiHttpClient)
        {
            _apiHttpClient = apiHttpClient;
        }
        async public Task<ApiResult<UserLoginResponseDTO>> LoginAsync(UserLoginRequestDTO userLogin)
        {
            var loginResult = await _apiHttpClient.PostAsync<UserLoginResponseDTO>(
                "/auth/login",
                data: userLogin
                );
            if (loginResult.Success)
            {
                return loginResult;
            }
            else
            {
                return ApiResult<UserLoginResponseDTO>.FromError("Fallo de login: " + loginResult.Message, null, loginResult.StatusCode);
            }
        }

        async public Task<ApiResult<UserRegisterResponseDTO>> RegisterAsync(UserRegisterRequestDTO userRegister)
        {
                var registerResponse = await _apiHttpClient.PostAsync<UserRegisterResponseDTO>(
                    "/auth/register",
                    data: userRegister
                    );

                return registerResponse;

        }
    }
}

