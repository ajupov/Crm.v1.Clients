using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Orders.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrdersClient : IOrdersClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public OrdersClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<Order> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<Order>(_host + "/Orders/v1/Get", new { id }, headers, ct);
        }

        public Task<List<Order>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<Order>>(_host + "/Orders/v1/GetList", null, ids, headers, ct);
        }

        public Task<OrderGetPagedListResponse> GetPagedListAsync(
            OrderGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<OrderGetPagedListResponse>(
                _host + "/Orders/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            Order order,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Orders/v1/Create", null, order, headers, ct);
        }

        public Task UpdateAsync(
            Order order,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/v1/Update", null, order, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/v1/Restore", null, ids, headers, ct);
        }
    }
}
