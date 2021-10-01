using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Orders.Requests;
using Crm.v1.Clients.Orders.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrderTypeChangesClient : IOrderTypeChangesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderTypeChangesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Orders/Types/Changes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<OrderTypeChangeGetPagedListResponse> GetPagedListAsync(
            OrderTypeChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<OrderTypeChangeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }
    }
}
