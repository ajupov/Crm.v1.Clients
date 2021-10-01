using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Account.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Account.Clients
{
    public class AccountSettingsClient : IAccountSettingsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public AccountSettingsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Account/Settings/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<AccountSetting> GetAsync(
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<AccountSetting>(UriBuilder.Combine(_url, "Get"), null, headers, ct);
        }
    }
}
