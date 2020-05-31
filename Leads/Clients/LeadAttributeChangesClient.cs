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
    public class LeadAttributeChangesClient : ILeadAttributeChangesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public LeadAttributeChangesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Leads/Attributes/Changes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<LeadAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<LeadAttributeChangeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }
    }
}
