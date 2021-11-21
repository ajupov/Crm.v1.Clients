using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Stock.Models;

namespace Crm.v1.Clients.Stock.Clients
{
    public interface IStockBalanceChangesClient
    {
        Task<StockBalanceChangeGetPagedListResponse> GetPagedListAsync(
            StockBalanceChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
