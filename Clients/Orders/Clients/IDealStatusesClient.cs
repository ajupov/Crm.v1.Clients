using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Orders.Models;
using Crm.v1.Clients.Clients.Orders.Requests;
using Crm.v1.Clients.Clients.Orders.Responses;

namespace Crm.v1.Clients.Clients.Orders.Clients
{
    public interface IDealStatusesClient
    {
        Task<DealStatus> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<DealStatus>> GetListAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<DealStatusGetPagedListResponse> GetPagedListAsync(
            
            DealStatusGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<Guid> CreateAsync(DealStatus status, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(DealStatus status, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
