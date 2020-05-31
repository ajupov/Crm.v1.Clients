using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.V1.Clients.Leads.Requests;
using Crm.V1.Clients.Leads.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.V1.Clients.Leads.Clients
{
    public class LeadSourceChangesClient : ILeadSourceChangesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public LeadSourceChangesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Leads/Sources/Changes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<LeadSourceChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadSourceChangeGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<LeadSourceChangeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }
    }
}
