using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Suppliers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Suppliers.Clients
{
    public class SupplierAttributesClient : ISupplierAttributesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public SupplierAttributesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<SupplierAttribute> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<SupplierAttribute>(
                _host + "/Suppliers/Attributes/v1/Get", new { id }, headers, ct);
        }

        public Task<List<SupplierAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<SupplierAttribute>>(
                _host + "/Suppliers/Attributes/v1/GetList", null, ids, headers, ct);
        }

        public Task<SupplierAttributeGetPagedListResponse> GetPagedListAsync(
            SupplierAttributeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<SupplierAttributeGetPagedListResponse>(
                _host + "/Suppliers/Attributes/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            SupplierAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Suppliers/Attributes/v1/Create", null, attribute, headers, ct);
        }

        public Task UpdateAsync(
            SupplierAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Suppliers/Attributes/v1/Update", null, attribute, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Suppliers/Attributes/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Suppliers/Attributes/v1/Restore", null, ids, headers, ct);
        }
    }
}
