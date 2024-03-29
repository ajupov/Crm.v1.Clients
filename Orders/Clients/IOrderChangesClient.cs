using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Orders.Models;

namespace Crm.v1.Clients.Orders.Clients
{
    public interface IOrderChangesClient
    {
        Task<OrderChangeGetPagedListResponse> GetPagedListAsync(
            OrderChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
