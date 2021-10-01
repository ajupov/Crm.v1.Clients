using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Tasks.Requests;
using Crm.v1.Clients.Tasks.Responses;
using CrmTaskStatus = Crm.v1.Clients.Tasks.Models.TaskStatus;

namespace Crm.v1.Clients.Tasks.Clients
{
    public interface ITaskStatusesClient
    {
        Task<CrmTaskStatus> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<List<CrmTaskStatus>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<TaskStatusGetPagedListResponse> GetPagedListAsync(
            TaskStatusGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            CrmTaskStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task UpdateAsync(
            CrmTaskStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
