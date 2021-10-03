using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Account.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Account.Clients
{
    public class AccountFlagsClient : IAccountFlagsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public AccountFlagsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<bool> IsSetAsync(
            AccountFlagType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<bool>(_host + "/Account/Flags/v1/IsSet", new { type }, headers, ct);
        }

        public Task<List<AccountFlagType>> GetNotSetListAsync(
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<List<AccountFlagType>>(
                _host + "/Account/Flags/v1/GetNotSetList", null, headers, ct);
        }

        public Task SetAsync(
            AccountFlagType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PutAsync(_host + "/Account/Flags/v1/Set", null, new { type }, headers, ct);
        }
    }
}
