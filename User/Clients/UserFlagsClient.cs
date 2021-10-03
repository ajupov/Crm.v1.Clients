using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.User.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.User.Clients
{
    public class UserFlagsClient : IUserFlagsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public UserFlagsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<bool> IsSetAsync(
            UserFlagType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<bool>(_host + "/User/Flags/v1/IsSet", new { type }, headers, ct);
        }

        public Task<List<UserFlagType>> GetNotSetListAsync(
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<List<UserFlagType>>(
                _host + "/User/Flags/v1/GetNotSetList", null, headers, ct);
        }

        public Task SetAsync(
            UserFlagType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PutAsync(
                _host + "/User/Flags/v1/Set", null, new { type }, headers, ct);
        }
    }
}
