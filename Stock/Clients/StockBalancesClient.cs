using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Stock.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Stock.Clients
{
    public class StockBalancesClient : IStockBalancesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public StockBalancesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<StockBalance> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<StockBalance>(_host + "/Stock/Balances/v1/Get", new { id }, headers, ct);
        }

        public Task<List<StockBalance>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<StockBalance>>(_host + "/Stock/Balances/v1/GetList", null, ids, headers, ct);
        }

        public Task<StockBalanceGetPagedListResponse> GetPagedListAsync(
            StockBalanceGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<StockBalanceGetPagedListResponse>(
                _host + "/Stock/Balances/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            StockBalance balance,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Stock/Balances/v1/Create", null, balance, headers, ct);
        }

        public Task UpdateAsync(
            StockBalance balance,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Balances/v1/Update", null, balance, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Balances/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Balances/v1/Restore", null, ids, headers, ct);
        }
    }
}
