using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Orders.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrderTypesClient : IOrderTypesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public OrderTypesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<OrderType> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<OrderType>(_host + "/Orders/Types/v1/Get", new { id }, headers, ct);
        }

        public Task<List<OrderType>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<OrderType>>(
                _host + "/Orders/Types/v1/GetList", null, ids, headers, ct);
        }

        public Task<OrderTypeGetPagedListResponse> GetPagedListAsync(
            OrderTypeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<OrderTypeGetPagedListResponse>(
                _host + "/Orders/Types/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            OrderType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Orders/Types/v1/Create", null, type, headers, ct);
        }

        public Task UpdateAsync(
            OrderType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/Types/v1/Update", null, type, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/Types/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/Types/v1/Restore", null, ids, headers, ct);
        }
    }
}
