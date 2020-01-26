using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.Common.All.Types.AttributeType;
using Crm.v1.Clients.Deals.Models;
using Crm.v1.Clients.Deals.RequestParameters;

namespace Crm.v1.Clients.Deals.Clients
{
    public interface IDealAttributesClient
    {
        Task<Dictionary<string, AttributeType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<DealAttribute> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<DealAttribute>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default);

        Task<List<DealAttribute>> GetPagedListAsync(
            string accessToken,
            DealAttributeGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, DealAttribute attribute, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, DealAttribute attribute, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}