using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.User.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.User.Clients
{
    public class UserSettingsClient : IUserSettingsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public UserSettingsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<UserSetting> GetAsync(Dictionary<string, string> headers = default, CancellationToken ct = default)
        {
            return _factory.GetAsync<UserSetting>(_host + "/User/Settings/v1/Get", null, headers, ct);
        }
    }
}
