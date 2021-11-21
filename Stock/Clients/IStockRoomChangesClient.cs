using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Stock.Models;

namespace Crm.v1.Clients.Stock.Clients
{
    public interface IStockRoomChangesClient
    {
        Task<StockRoomChangeGetPagedListResponse> GetPagedListAsync(
            StockRoomChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
