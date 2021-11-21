using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Stock.Models;

namespace Crm.v1.Clients.Stock.Clients
{
    public interface IStockArrivalChangesClient
    {
        Task<StockArrivalChangeGetPagedListResponse> GetPagedListAsync(
            StockArrivalChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
