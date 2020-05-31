using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Activities.Models;
using Crm.V1.Clients.Activities.Requests;
using Crm.V1.Clients.Activities.Responses;

namespace Crm.V1.Clients.Activities.Clients
{
    public interface IActivityStatusesClient
    {
        Task<ActivityStatus> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<ActivityStatus>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default);

        Task<ActivityStatusGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityStatusGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, ActivityStatus status, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, ActivityStatus status, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}
