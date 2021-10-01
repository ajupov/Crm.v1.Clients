using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Orders.Models;
using Crm.v1.Clients.Orders.Requests;
using Crm.v1.Clients.Orders.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrderCommentsClient : IOrderCommentsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderCommentsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Orders/Comments/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<OrderCommentGetPagedListResponse> GetPagedListAsync(
            OrderCommentGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<OrderCommentGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task CreateAsync(
            OrderComment comment,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync(UriBuilder.Combine(_url, "Create"), comment, headers, ct);
        }
    }
}
