using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Orders.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrderTypeChangesClient : IOrderTypeChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public OrderTypeChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<OrderTypeChangeGetPagedListResponse> GetPagedListAsync(
            OrderTypeChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<OrderTypeChangeGetPagedListResponse>(
                _host + "/Orders/Types/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
