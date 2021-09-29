using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Clients.Auth.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Clients.Auth.Clients
{
    public class UserInfoClient : IUserInfoClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public UserInfoClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "UserInfo");
            _httpClientFactory = httpClientFactory;
        }

        public Task<UserInfo> GetAsync(Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<UserInfo>(UriBuilder.Combine(_url, "Get"), null, headers, ct);
        }
    }
}
