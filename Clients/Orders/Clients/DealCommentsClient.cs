using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Clients.Orders.Models;
using Crm.v1.Clients.Clients.Orders.Requests;
using Crm.v1.Clients.Clients.Orders.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Clients.Orders.Clients
{
    public class DealCommentsClient : IDealCommentsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public DealCommentsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Deals/Comments/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<DealCommentGetPagedListResponse> GetPagedListAsync(

            DealCommentGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<DealCommentGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task CreateAsync(DealComment comment, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync(UriBuilder.Combine(_url, "Create"), comment, accessToken, ct);
        }
    }
}
