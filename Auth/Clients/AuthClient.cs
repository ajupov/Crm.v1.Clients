using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Auth.Clients
{
    public class AuthClient : IAuthClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public AuthClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<bool> IsAuthenticatedAsync(
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<bool>(_host + "/Auth/IsAuthenticated", null, headers, ct);
        }
    }
}
