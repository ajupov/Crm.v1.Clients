using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Products.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Products.Clients
{
    public class ProductAttributesClient : IProductAttributesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public ProductAttributesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<ProductAttribute> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<ProductAttribute>(_host + "/Products/Attributes/v1/Get", new { id }, headers, ct);
        }

        public Task<List<ProductAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<ProductAttribute>>(
                _host + "/Products/Attributes/v1/GetList", null, ids, headers, ct);
        }

        public Task<ProductAttributeGetPagedListResponse> GetPagedListAsync(
            ProductAttributeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<ProductAttributeGetPagedListResponse>(
                _host + "/Products/Attributes/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            ProductAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Products/Attributes/v1/Create", null, attribute, headers, ct);
        }

        public Task UpdateAsync(
            ProductAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/Attributes/v1/Update", null, attribute, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/Attributes/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Products/Attributes/v1/Restore", null, ids, headers, ct);
        }
    }
}
