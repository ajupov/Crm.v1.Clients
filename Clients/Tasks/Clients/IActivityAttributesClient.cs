using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.Common.All.Types.AttributeType;
using Crm.v1.Clients.Clients.Tasks.Models;
using Crm.v1.Clients.Clients.Tasks.Requests;
using Crm.v1.Clients.Clients.Tasks.Responses;

namespace Crm.v1.Clients.Clients.Tasks.Clients
{
    public interface IActivityAttributesClient
    {
        Task<Dictionary<string, AttributeType>> GetTypesAsync(Dictionary<string, string> headers, CancellationToken ct = default);

        Task<ActivityAttribute> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<ActivityAttribute>> GetListAsync(
            
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<ActivityAttributeGetPagedListResponse> GetPagedListAsync(
            
            ActivityAttributeGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<Guid> CreateAsync(ActivityAttribute attribute, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(ActivityAttribute attribute, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
