using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Tasks.Models;
using Crm.v1.Clients.Clients.Tasks.Requests;
using Crm.v1.Clients.Clients.Tasks.Responses;

namespace Crm.v1.Clients.Clients.Tasks.Clients
{
    public interface IActivityStatusesClient
    {
        Task<ActivityStatus> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<ActivityStatus>> GetListAsync(
            
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<ActivityStatusGetPagedListResponse> GetPagedListAsync(
            
            ActivityStatusGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<Guid> CreateAsync(ActivityStatus status, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(ActivityStatus status, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
