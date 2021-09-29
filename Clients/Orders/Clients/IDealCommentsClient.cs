using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Orders.Models;
using Crm.v1.Clients.Clients.Orders.Requests;
using Crm.v1.Clients.Clients.Orders.Responses;

namespace Crm.v1.Clients.Clients.Orders.Clients
{
    public interface IDealCommentsClient
    {
        Task<DealCommentGetPagedListResponse> GetPagedListAsync(
            
            DealCommentGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task CreateAsync(DealComment comment, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
