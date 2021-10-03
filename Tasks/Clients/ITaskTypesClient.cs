using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Tasks.Models;
using Task = System.Threading.Tasks.Task;

namespace Crm.v1.Clients.Tasks.Clients
{
    public interface ITaskTypesClient
    {
        Task<TaskType> GetAsync(Guid id, Dictionary<string, string> headers = default, CancellationToken ct = default);

        Task<List<TaskType>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<TaskTypeGetPagedListResponse> GetPagedListAsync(
            TaskTypeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            TaskType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task UpdateAsync(TaskType type, Dictionary<string, string> headers = default, CancellationToken ct = default);

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
