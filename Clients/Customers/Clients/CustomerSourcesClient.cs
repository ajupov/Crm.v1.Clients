using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Clients.Customers.Models;
using Crm.v1.Clients.Clients.Customers.Requests;
using Crm.v1.Clients.Clients.Customers.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Clients.Customers.Clients
{
    public class CustomerSourcesClient : ICustomerSourcesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public CustomerSourcesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Customers/Sources/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<CustomerSource> GetAsync(
            Guid id,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<CustomerSource>(
                UriBuilder.Combine(_url, "Get"), new { id }, headers, ct);
        }

        public Task<List<CustomerSource>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<CustomerSource>>(
                UriBuilder.Combine(_url, "GetList"), ids, headers, ct);
        }

        public Task<CustomerSourceGetPagedListResponse> GetPagedListAsync(
            CustomerSourceGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<CustomerSourceGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            CustomerSource source,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), source, headers, ct);
        }

        public Task UpdateAsync(
            CustomerSource source,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), source, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, headers, ct);
        }
    }
}
