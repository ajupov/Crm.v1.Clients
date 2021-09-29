using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Tasks.Models;
using Crm.v1.Clients.Tasks.Requests;
using Crm.v1.Clients.Tasks.Responses;
using Task = System.Threading.Tasks.Task;

namespace Crm.v1.Clients.Tasks.Clients
{
    public interface ITaskAttributesClient
    {
        Task<TaskAttribute> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<TaskAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<TaskAttributeGetPagedListResponse> GetPagedListAsync(
            TaskAttributeGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            TaskAttribute attribute,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task UpdateAsync(
            TaskAttribute attribute,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
