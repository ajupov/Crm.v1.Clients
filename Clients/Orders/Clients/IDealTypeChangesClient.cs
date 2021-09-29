using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Orders.Requests;
using Crm.v1.Clients.Clients.Orders.Responses;

namespace Crm.v1.Clients.Clients.Orders.Clients
{
    public interface IDealTypeChangesClient
    {
        Task<DealTypeChangeGetPagedListResponse> GetPagedListAsync(
            
            DealTypeChangeGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
