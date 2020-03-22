using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Activities.Models;
using Crm.v1.Clients.Activities.Requests;
using Crm.v1.Clients.Activities.Responses;

namespace Crm.v1.Clients.Activities.Clients
{
    public interface IActivityTypesClient
    {
        Task<ActivityType> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<ActivityType>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default);

        Task<ActivityTypeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityTypeGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, ActivityType type, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, ActivityType type, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}