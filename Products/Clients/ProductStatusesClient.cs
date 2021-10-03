using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Products.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Products.Clients
{
    public class ProductStatusesClient : IProductStatusesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public ProductStatusesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<ProductStatus> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<ProductStatus>(
                _host + "/Products/Statuses/v1/Get", new { id }, headers, ct);
        }

        public Task<List<ProductStatus>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<ProductStatus>>(
                _host + "/Products/Statuses/v1/GetList", null, ids, headers, ct);
        }

        public Task<ProductStatusGetPagedListResponse> GetPagedListAsync(
            ProductStatusGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<ProductStatusGetPagedListResponse>(
                _host + "/Products/Statuses/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            ProductStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Products/Statuses/v1/Create", null, status, headers, ct);
        }

        public Task UpdateAsync(
            ProductStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/Statuses/v1/Update", null, status, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/Statuses/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/Statuses/v1/Restore", null, ids, headers, ct);
        }
    }
}
