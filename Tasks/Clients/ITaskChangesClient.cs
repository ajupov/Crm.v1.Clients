using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Tasks.Models;

namespace Crm.v1.Clients.Tasks.Clients
{
    public interface ITaskChangesClient
    {
        Task<TaskChangeGetPagedListResponse> GetPagedListAsync(
            TaskChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
