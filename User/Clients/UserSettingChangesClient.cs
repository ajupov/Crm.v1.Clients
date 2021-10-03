using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.User.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.User.Clients
{
    public class UserSettingChangesClient : IUserSettingChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public UserSettingChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<UserSettingChangeGetPagedListResponse> GetPagedListAsync(
            UserSettingChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<UserSettingChangeGetPagedListResponse>(
                _host + "/User/Settings/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
