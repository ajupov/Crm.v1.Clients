using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Account.Requests;
using Crm.v1.Clients.Account.Responses;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Account.Clients
{
    public class AccountSettingChangesClient : IAccountSettingChangesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public AccountSettingChangesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Account/Settings/Changes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<AccountSettingChangeGetPagedListResponse> GetPagedListAsync(
            AccountSettingChangeGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<AccountSettingChangeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }
    }
}
