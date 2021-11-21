using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Stock.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Stock.Clients
{
    public class StockArrivalChangesClient : IStockArrivalChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public StockArrivalChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<StockArrivalChangeGetPagedListResponse> GetPagedListAsync(
            StockArrivalChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<StockArrivalChangeGetPagedListResponse>(
                _host + "/Stock/Arrivals/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
