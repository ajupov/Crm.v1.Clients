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
    public class ActivitiesClient : IActivitiesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ActivitiesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Activities/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<Activity> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<Activity>(UriBuilder.Combine(_url, "Get"), new {id}, accessToken, ct);
        }

        public Task<List<Activity>> GetListAsync(

            IEnumerable<Guid> ids,
            Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<Activity>>(
                UriBuilder.Combine(_url, "GetList"), ids, accessToken, ct);
        }

        public Task<ActivityGetPagedListResponse> GetPagedListAsync(

            ActivityGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<ActivityGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task<Guid> CreateAsync(Activity activity, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), activity, accessToken, ct);
        }

        public Task UpdateAsync(Activity activity, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), activity, accessToken, ct);
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
