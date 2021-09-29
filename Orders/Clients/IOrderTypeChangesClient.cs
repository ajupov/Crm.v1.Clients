using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Orders.Requests;
using Crm.v1.Clients.Orders.Responses;

namespace Crm.v1.Clients.Orders.Clients
{
    public interface IOrderTypeChangesClient
    {
        Task<OrderTypeChangeGetPagedListResponse> GetPagedListAsync(
            OrderTypeChangeGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);
    }
}
