using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Stock.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Stock.Clients
{
    public class StockArrivalsClient : IStockArrivalsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public StockArrivalsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<StockArrival> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<StockArrival>(_host + "/Stock/Arrivals/v1/Get", new { id }, headers, ct);
        }

        public Task<List<StockArrival>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<StockArrival>>(_host + "/Stock/Arrivals/v1/GetList", null, ids, headers, ct);
        }

        public Task<StockArrivalGetPagedListResponse> GetPagedListAsync(
            StockArrivalGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<StockArrivalGetPagedListResponse>(
                _host + "/Stock/Arrivals/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            StockArrival arrival,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Stock/Arrivals/v1/Create", null, arrival, headers, ct);
        }

        public Task UpdateAsync(
            StockArrival arrival,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Arrivals/v1/Update", null, arrival, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Arrivals/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Arrivals/v1/Restore", null, ids, headers, ct);
        }
    }
}
