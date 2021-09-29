using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Tasks.Requests;
using Crm.v1.Clients.Clients.Tasks.Responses;

namespace Crm.v1.Clients.Clients.Tasks.Clients
{
    public interface IActivityStatusChangesClient
    {
        Task<ActivityStatusChangeGetPagedListResponse> GetPagedListAsync(
            
            ActivityStatusChangeGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
