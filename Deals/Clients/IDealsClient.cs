using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Deals.Models;
using Crm.v1.Clients.Deals.Requests;
using Crm.v1.Clients.Deals.Responses;

namespace Crm.v1.Clients.Deals.Clients
{
    public interface IDealsClient
    {
        Task<Deal> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<Deal>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<DealGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            DealGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, Deal deal, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, Deal deal, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}