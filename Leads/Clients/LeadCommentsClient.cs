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
    public class LeadCommentsClient : ILeadCommentsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public LeadCommentsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Leads/Comments/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<LeadCommentGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadCommentGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<LeadCommentGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task CreateAsync(string accessToken, LeadComment comment, CancellationToken ct = default)
        {
            return _httpClientFactory.PutJsonAsync(UriBuilder.Combine(_url, "Create"), comment, accessToken, ct);
        }
    }
}
