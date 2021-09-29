using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Clients.User.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Clients.User.Clients
{
    public class UserSettingsClient : IUserSettingsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public UserSettingsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "User/Settings/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<UserSetting> GetAsync(Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<UserSetting>(UriBuilder.Combine(_url, "Get"), null, headers, ct);
        }
    }
}
