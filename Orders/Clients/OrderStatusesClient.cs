using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Orders.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrderStatusesClient : IOrderStatusesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public OrderStatusesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<OrderStatus> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<OrderStatus>(_host + "/Orders/Statuses/v1/Get", new { id }, headers, ct);
        }

        public Task<List<OrderStatus>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<OrderStatus>>(
                _host + "/Orders/Statuses/v1/GetList", null, ids, headers, ct);
        }

        public Task<OrderStatusGetPagedListResponse> GetPagedListAsync(
            OrderStatusGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<OrderStatusGetPagedListResponse>(
                _host + "/Orders/Statuses/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            OrderStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Orders/Statuses/v1/Create", null, status, headers, ct);
        }

        public Task UpdateAsync(
            OrderStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/Statuses/v1/Update", null, status, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/Statuses/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/Statuses/v1/Restore", null, ids, headers, ct);
        }
    }
}
