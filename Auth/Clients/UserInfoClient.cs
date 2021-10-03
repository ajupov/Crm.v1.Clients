using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Auth.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Auth.Clients
{
    public class UserInfoClient : IUserInfoClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public UserInfoClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<UserInfo> GetAsync(Dictionary<string, string> headers = default, CancellationToken ct = default)
        {
            return _factory.GetAsync<UserInfo>(_host + "/UserInfo/Get", null, headers, ct);
        }
    }
}
