using System.Collections.Concurrent;
using System.Net.Http.Headers;

namespace Infrastructure.API
{
    public static class AuthHeaderRegistry
    {
        private static readonly ConcurrentBag<HttpClient> _clients = new();

        public static void Register(HttpClient client)
        {
            _clients.Add(client);
            Apply(client, TokenBroker.CurrentToken);
        }

        public static void UpdateBearer(string? token)
        {
            foreach (var c in _clients)
            {
                Apply(c, token);
            }
        }

        private static void Apply(HttpClient client, string? token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                client.DefaultRequestHeaders.Authorization = null;
            }
            else
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
}