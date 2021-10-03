using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Orders.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrderStatusChangesClient : IOrderStatusChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public OrderStatusChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<OrderStatusChangeGetPagedListResponse> GetPagedListAsync(
            OrderStatusChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<OrderStatusChangeGetPagedListResponse>(
                _host + "/Orders/Statuses/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
