using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.V1.Clients.Leads.Models;
using Crm.V1.Clients.Leads.Requests;
using Crm.V1.Clients.Leads.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.V1.Clients.Leads.Clients
{
    public class LeadSourcesClient : ILeadSourcesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public LeadSourcesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Leads/Sources/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<LeadSource> GetAsync(string accessToken, Guid id, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<LeadSource>(UriBuilder.Combine(_url, "Get"), new {id}, accessToken, ct);
        }

        public Task<List<LeadSource>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<LeadSource>>(
                UriBuilder.Combine(_url, "GetList"), ids, accessToken, ct);
        }

        public Task<LeadSourceGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadSourceGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<LeadSourceGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task<Guid> CreateAsync(string accessToken, LeadSource source, CancellationToken ct = default)
        {
            return _httpClientFactory.PutJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), source, accessToken, ct);
        }

        public Task UpdateAsync(string accessToken, LeadSource source, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), source, accessToken, ct);
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
