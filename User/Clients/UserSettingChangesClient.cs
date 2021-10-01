using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.User.Requests;
using Crm.v1.Clients.User.Responses;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.User.Clients
{
    public class UserSettingChangesClient : IUserSettingChangesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public UserSettingChangesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "User/Settings/Changes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<UserSettingChangeGetPagedListResponse> GetPagedListAsync(
            UserSettingChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<UserSettingChangeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }
    }
}
