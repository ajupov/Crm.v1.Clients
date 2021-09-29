using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Tasks.Models;
using Crm.v1.Clients.Tasks.Requests;
using Crm.v1.Clients.Tasks.Responses;
using Task = System.Threading.Tasks.Task;

namespace Crm.v1.Clients.Tasks.Clients
{
    public interface ITaskCommentsClient
    {
        Task<TaskCommentGetPagedListResponse> GetPagedListAsync(
            TaskCommentGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task CreateAsync(TaskComment comment, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
