using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Auth.Clients
{
    public class AuthClient : IAuthClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Auth");
            _httpClientFactory = httpClientFactory;
        }

        public Task<bool> IsAuthenticatedAsync(
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<bool>(UriBuilder.Combine(_url, "IsAuthenticated"), null, headers, ct);
        }
    }
}
