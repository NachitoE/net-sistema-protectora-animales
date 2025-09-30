using System;

namespace Infrastructure.API
{
    public static class TokenBroker
    {
        private static string? _token;

        public static string? CurrentToken
        {
            get { return _token; }
        }

        public static void SetToken(string? token)
        {
            _token = token;
            AuthHeaderRegistry.UpdateBearer(_token);
        }

        public static void Clear() => SetToken(null);
    }
}