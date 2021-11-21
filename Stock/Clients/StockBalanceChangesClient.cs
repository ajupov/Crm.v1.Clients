using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Stock.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Stock.Clients
{
    public class StockBalanceChangesClient : IStockBalanceChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public StockBalanceChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<StockBalanceChangeGetPagedListResponse> GetPagedListAsync(
            StockBalanceChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<StockBalanceChangeGetPagedListResponse>(
                _host + "/Stock/Balances/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
