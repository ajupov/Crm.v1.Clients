using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Products.Models;
using Crm.v1.Clients.Products.Requests;
using Crm.v1.Clients.Products.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Products.Clients
{
    public class ProductStatusesClient : IProductStatusesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductStatusesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Products/Statuses/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<ProductStatus> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<ProductStatus>(
                UriBuilder.Combine(_url, "Get"), new { id }, headers, ct);
        }

        public Task<List<ProductStatus>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<ProductStatus>>(
                UriBuilder.Combine(_url, "GetList"), ids, headers, ct);
        }

        public Task<ProductStatusGetPagedListResponse> GetPagedListAsync(
            ProductStatusGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<ProductStatusGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            ProductStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), status, headers, ct);
        }

        public Task UpdateAsync(
            ProductStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), status, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, headers, ct);
        }
    }
}
