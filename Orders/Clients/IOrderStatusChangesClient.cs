using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Orders.Models;

namespace Crm.v1.Clients.Orders.Clients
{
    public interface IOrderStatusChangesClient
    {
        Task<OrderStatusChangeGetPagedListResponse> GetPagedListAsync(
            OrderStatusChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
