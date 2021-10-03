using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Tasks.Models;

namespace Crm.v1.Clients.Tasks.Clients
{
    public interface ITaskStatusChangesClient
    {
        Task<TaskStatusChangeGetPagedListResponse> GetPagedListAsync(
            TaskStatusChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
