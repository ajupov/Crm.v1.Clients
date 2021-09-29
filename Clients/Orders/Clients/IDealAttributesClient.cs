using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Orders.Models;
using Crm.v1.Clients.Clients.Orders.Requests;
using Crm.v1.Clients.Clients.Orders.Responses;

namespace Crm.v1.Clients.Clients.Orders.Clients
{
    public interface IDealAttributesClient
    {
        Task<DealAttribute> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<DealAttribute>> GetListAsync(

            IEnumerable<Guid> ids,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<DealAttributeGetPagedListResponse> GetPagedListAsync(

            DealAttributeGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<Guid> CreateAsync(DealAttribute attribute, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(DealAttribute attribute, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
