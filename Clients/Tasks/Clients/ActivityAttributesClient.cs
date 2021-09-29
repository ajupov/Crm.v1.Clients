using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Clients.Tasks.Models;
using Crm.v1.Clients.Clients.Tasks.Requests;
using Crm.v1.Clients.Clients.Tasks.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Clients.Tasks.Clients
{
    public class ActivityAttributesClient : IActivityAttributesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ActivityAttributesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Activities/Attributes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<ActivityAttribute> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<ActivityAttribute>(
                UriBuilder.Combine(_url, "Get"), new {id}, accessToken, ct);
        }

        public Task<List<ActivityAttribute>> GetListAsync(

            IEnumerable<Guid> ids,
            Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<ActivityAttribute>>(
                UriBuilder.Combine(_url, "GetList"), ids, accessToken, ct);
        }

        public Task<ActivityAttributeGetPagedListResponse> GetPagedListAsync(

            ActivityAttributeGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<ActivityAttributeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task<Guid> CreateAsync(ActivityAttribute attribute, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(
                UriBuilder.Combine(_url, "Create"), attribute, accessToken, ct);
        }

        public Task UpdateAsync(ActivityAttribute attribute, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), attribute, accessToken, ct);
        }

        public Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, accessToken, ct);
        }

        public Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, accessToken, ct);
        }
    }
}
