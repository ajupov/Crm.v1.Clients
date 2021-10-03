using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Products.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Products.Clients
{
    public class ProductsClient : IProductsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public ProductsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<Product> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<Product>(_host + "/Products/v1/Get", new { id }, headers, ct);
        }

        public Task<List<Product>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<Product>>(_host + "/Products/v1/GetList", null, ids, headers, ct);
        }

        public Task<ProductGetPagedListResponse> GetPagedListAsync(
            ProductGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<ProductGetPagedListResponse>(
                _host + "/Products/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            Product product,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Products/v1/Create", null, product, headers, ct);
        }

        public Task UpdateAsync(
            Product product,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/v1/Update", null, product, headers, ct);
        }

        public Task HideAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/v1/Hide", null, ids, headers, ct);
        }

        public Task ShowAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/v1/Show", null, ids, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/v1/Restore", null, ids, headers, ct);
        }
    }
}
