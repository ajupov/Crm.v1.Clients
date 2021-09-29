using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Customers.Models;
using Crm.v1.Clients.Clients.Customers.Requests;
using Crm.v1.Clients.Clients.Customers.Responses;

namespace Crm.v1.Clients.Clients.Customers.Clients
{
    public interface ILeadCommentsClient
    {
        Task<LeadCommentGetPagedListResponse> GetPagedListAsync(
            
            LeadCommentGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task CreateAsync(LeadComment comment, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
