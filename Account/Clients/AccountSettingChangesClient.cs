using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Account.Requests;
using Crm.v1.Clients.Account.Responses;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Account.Clients
{
    public class AccountSettingChangesClient : IAccountSettingChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public AccountSettingChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<AccountSettingChangeGetPagedListResponse> GetPagedListAsync(
            AccountSettingChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<AccountSettingChangeGetPagedListResponse>(
                _host + "/Account/Settings/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
