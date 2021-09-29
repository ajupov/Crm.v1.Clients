using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.Common.All.Types.AttributeType;
using Crm.v1.Clients.Clients.Customers.Models;
using Crm.v1.Clients.Clients.Customers.Requests;
using Crm.v1.Clients.Clients.Customers.Responses;

namespace Crm.v1.Clients.Clients.Customers.Clients
{
    public interface ILeadAttributesClient
    {
        Task<Dictionary<string, AttributeType>> GetTypesAsync(Dictionary<string, string> headers, CancellationToken ct = default);

        Task<LeadAttribute> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<LeadAttribute>> GetListAsync(
            
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<LeadAttributeGetPagedListResponse> GetPagedListAsync(
            
            LeadAttributeGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<Guid> CreateAsync(LeadAttribute attribute, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(LeadAttribute attribute, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
