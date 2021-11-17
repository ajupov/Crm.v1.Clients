using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Suppliers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Suppliers.Clients
{
    public class SuppliersClient : ISuppliersClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public SuppliersClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<Supplier> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<Supplier>(_host + "/Suppliers/v1/Get", new { id }, headers, ct);
        }

        public Task<List<Supplier>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<Supplier>>(
                _host + "/Suppliers/v1/GetList", null, ids, headers, ct);
        }

        public Task<SupplierGetPagedListResponse> GetPagedListAsync(
            SupplierGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<SupplierGetPagedListResponse>(
                _host + "/Suppliers/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            Supplier supplier,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Suppliers/v1/Create", null, supplier, headers, ct);
        }

        public Task UpdateAsync(
            Supplier supplier,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Suppliers/v1/Update", null, supplier, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Suppliers/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Suppliers/v1/Restore", null, ids, headers, ct);
        }
    }
}
