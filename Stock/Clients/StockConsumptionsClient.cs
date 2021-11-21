using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Stock.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Stock.Clients
{
    public class StockConsumptionsClient : IStockConsumptionsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public StockConsumptionsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<StockConsumption> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<StockConsumption>(_host + "/Stock/Consumptions/v1/Get", new { id }, headers, ct);
        }

        public Task<List<StockConsumption>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<StockConsumption>>(_host + "/Stock/Consumptions/v1/GetList", null, ids,
                headers, ct);
        }

        public Task<StockConsumptionGetPagedListResponse> GetPagedListAsync(
            StockConsumptionGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<StockConsumptionGetPagedListResponse>(
                _host + "/Stock/Consumptions/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            StockConsumption consumption,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Stock/Consumptions/v1/Create", null, consumption, headers, ct);
        }

        public Task UpdateAsync(
            StockConsumption consumption,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Consumptions/v1/Update", null, consumption, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Consumptions/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Consumptions/v1/Restore", null, ids, headers, ct);
        }
    }
}
