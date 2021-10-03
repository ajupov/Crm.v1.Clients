using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Orders.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrderAttributesClient : IOrderAttributesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public OrderAttributesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<OrderAttribute> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<OrderAttribute>(_host + "/Orders/Attributes/v1/Get", new { id }, headers, ct);
        }

        public Task<List<OrderAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<OrderAttribute>>(
                _host + "/Orders/Attributes/v1/GetList", null, ids, headers, ct);
        }

        public Task<OrderAttributeGetPagedListResponse> GetPagedListAsync(
            OrderAttributeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<OrderAttributeGetPagedListResponse>(
                _host + "/Orders/Attributes/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            OrderAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(
                _host + "/Orders/Attributes/v1/Create", null, attribute, headers, ct);
        }

        public Task UpdateAsync(
            OrderAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/Attributes/v1/Update", null, attribute, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/Attributes/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Orders/Attributes/v1/Restore", null, ids, headers, ct);
        }
    }
}
