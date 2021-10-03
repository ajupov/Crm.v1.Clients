using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Products.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Products.Clients
{
    public class ProductCategoriesClient : IProductCategoriesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public ProductCategoriesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<ProductCategory> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<ProductCategory>(
                _host + "/Products/Categories/v1/Get", new { id }, headers, ct);
        }

        public Task<List<ProductCategory>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<ProductCategory>>(
                _host + "/Products/Categories/v1/GetList", null, ids, headers, ct);
        }

        public Task<ProductCategoryGetPagedListResponse> GetPagedListAsync(
            ProductCategoryGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<ProductCategoryGetPagedListResponse>(
                _host + "/Products/Categories/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            ProductCategory category,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Products/Categories/v1/Create", null, category, headers, ct);
        }

        public Task UpdateAsync(
            ProductCategory category,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/Categories/v1/Update", null, category, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/Categories/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/Categories/v1/Restore", null, ids, headers, ct);
        }
    }
}
