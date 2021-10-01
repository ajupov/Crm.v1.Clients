using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Orders.Models;
using Crm.v1.Clients.Orders.Requests;
using Crm.v1.Clients.Orders.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrderStatusesClient : IOrderStatusesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderStatusesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Orders/Statuses/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<OrderStatus> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<OrderStatus>(UriBuilder.Combine(_url, "Get"), new { id }, headers, ct);
        }

        public Task<List<OrderStatus>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<OrderStatus>>(
                UriBuilder.Combine(_url, "GetList"), ids, headers, ct);
        }

        public Task<OrderStatusGetPagedListResponse> GetPagedListAsync(
            OrderStatusGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<OrderStatusGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            OrderStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), status, headers, ct);
        }

        public Task UpdateAsync(
            OrderStatus status,
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
