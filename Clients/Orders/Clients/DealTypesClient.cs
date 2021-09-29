using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Clients.Orders.Models;
using Crm.v1.Clients.Clients.Orders.Requests;
using Crm.v1.Clients.Clients.Orders.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Clients.Orders.Clients
{
    public class DealTypesClient : IDealTypesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public DealTypesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Deals/Types/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<DealType> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<DealType>(UriBuilder.Combine(_url, "Get"), new {id}, accessToken, ct);
        }

        public Task<List<DealType>> GetListAsync(

            IEnumerable<Guid> ids,
            Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<DealType>>(
                UriBuilder.Combine(_url, "GetList"), ids, accessToken, ct);
        }

        public Task<DealTypeGetPagedListResponse> GetPagedListAsync(

            DealTypeGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<DealTypeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task<Guid> CreateAsync(DealType type, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), type, accessToken, ct);
        }

        public Task UpdateAsync(DealType type, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), type, accessToken, ct);
        }

        public Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, accessToken, ct);
        }

        public Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, accessToken, ct);
        }
    }
}
