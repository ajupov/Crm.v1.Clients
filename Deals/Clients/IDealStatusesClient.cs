using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Deals.Models;
using Crm.V1.Clients.Deals.Requests;
using Crm.V1.Clients.Deals.Responses;

namespace Crm.V1.Clients.Deals.Clients
{
    public interface IDealStatusesClient
    {
        Task<DealStatus> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<DealStatus>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<DealStatusGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            DealStatusGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, DealStatus status, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, DealStatus status, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}
