using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.V1.Clients.Activities.Models;
using Crm.V1.Clients.Activities.Requests;
using Crm.V1.Clients.Activities.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.V1.Clients.Activities.Clients
{
    public class ActivityStatusesClient : IActivityStatusesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ActivityStatusesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Activities/Statuses/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<ActivityStatus> GetAsync(string accessToken, Guid id, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<ActivityStatus>(
                UriBuilder.Combine(_url, "Get"), new {id}, accessToken, ct);
        }

        public Task<List<ActivityStatus>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<ActivityStatus>>(
                UriBuilder.Combine(_url, "GetList"), ids, accessToken, ct);
        }

        public Task<ActivityStatusGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityStatusGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<ActivityStatusGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task<Guid> CreateAsync(string accessToken, ActivityStatus status, CancellationToken ct = default)
        {
            return _httpClientFactory.PutJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), status, accessToken, ct);
        }

        public Task UpdateAsync(string accessToken, ActivityStatus status, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), status, accessToken, ct);
        }

        public Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, accessToken, ct);
        }

        public Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, accessToken, ct);
        }
    }
}
