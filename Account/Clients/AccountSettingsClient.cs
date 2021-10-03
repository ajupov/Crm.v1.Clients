using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Account.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Account.Clients
{
    public class AccountSettingsClient : IAccountSettingsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public AccountSettingsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<AccountSetting> GetAsync(
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<AccountSetting>(_host + "/Account/Settings/v1/Get", null, headers, ct);
        }

        public Task<AccountSetting> SetActivityIndustryAsync(
            AccountSettingActivityIndustry industry,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PutAsync<AccountSetting>(
                _host + "/Account/Settings/v1/SetActivityIndustry", null, new { industry }, headers, ct);
        }
    }
}
