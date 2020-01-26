using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.Common.All.Types.AttributeType;
using Crm.v1.Clients.Activities.Models;
using Crm.v1.Clients.Activities.RequestParameters;

namespace Crm.v1.Clients.Activities.Clients
{
    public interface IActivityAttributesClient
    {
        Task<Dictionary<string, AttributeType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<ActivityAttribute> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<ActivityAttribute>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default);

        Task<List<ActivityAttribute>> GetPagedListAsync(
            string accessToken,
            ActivityAttributeGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, ActivityAttribute attribute, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, ActivityAttribute attribute, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}