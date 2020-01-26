using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Deals.Models;
using Crm.v1.Clients.Deals.RequestParameters;

namespace Crm.v1.Clients.Deals.Clients
{
    public interface IDealTypesClient
    {
        Task<DealType> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<DealType>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<List<DealType>> GetPagedListAsync(
            string accessToken,
            DealTypeGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, DealType type, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, DealType type, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}