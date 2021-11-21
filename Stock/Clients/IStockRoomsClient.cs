using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Stock.Models;

namespace Crm.v1.Clients.Stock.Clients
{
    public interface IStockRoomsClient
    {
        Task<StockRoom> GetAsync(Guid id, Dictionary<string, string> headers = default, CancellationToken ct = default);

        Task<List<StockRoom>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<StockRoomGetPagedListResponse> GetPagedListAsync(
            StockRoomGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            StockRoom room,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task UpdateAsync(StockRoom room, Dictionary<string, string> headers = default, CancellationToken ct = default);

        Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
