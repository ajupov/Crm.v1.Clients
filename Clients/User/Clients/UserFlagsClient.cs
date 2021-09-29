using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Clients.User.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Clients.User.Clients
{
    public class UserFlagsClient : IUserFlagsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public UserFlagsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "User/Flags/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<bool> IsSetAsync(
            UserFlagType type,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<bool>(UriBuilder.Combine(_url, "IsSet"), new { type }, headers, ct);
        }

        public Task<List<UserFlagType>> GetNotSetListAsync(
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<List<UserFlagType>>(UriBuilder.Combine(_url, "GetNotSetList"), null,
                headers, ct);
        }

        public Task SetAsync(UserFlagType type, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PutJsonAsync(UriBuilder.Combine(_url, "Set"), new { type }, headers, ct);
        }
    }
}
