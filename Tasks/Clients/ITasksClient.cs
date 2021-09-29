using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Tasks.Requests;
using Crm.v1.Clients.Tasks.Responses;
using CrmTask = Crm.v1.Clients.Tasks.Models.Task;
using Task = System.Threading.Tasks.Task;

namespace Crm.v1.Clients.Tasks.Clients
{
    public interface ITasksClient
    {
        Task<CrmTask> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<CrmTask>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<TaskGetPagedListResponse> GetPagedListAsync(
            TaskGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(CrmTask task, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(CrmTask task, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
