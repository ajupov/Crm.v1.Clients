using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Orders.Models;
using Crm.v1.Clients.Clients.Orders.Requests;
using Crm.v1.Clients.Clients.Orders.Responses;

namespace Crm.v1.Clients.Clients.Orders.Clients
{
    public interface IDealTypesClient
    {
        Task<DealType> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<DealType>> GetListAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<DealTypeGetPagedListResponse> GetPagedListAsync(
            
            DealTypeGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<Guid> CreateAsync(DealType type, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(DealType type, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
