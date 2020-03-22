using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.Common.All.Types.AttributeType;
using Crm.v1.Clients.Leads.Models;
using Crm.v1.Clients.Leads.Requests;
using Crm.v1.Clients.Leads.Responses;

namespace Crm.v1.Clients.Leads.Clients
{
    public interface ILeadAttributesClient
    {
        Task<Dictionary<string, AttributeType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<LeadAttribute> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<LeadAttribute>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default);

        Task<LeadAttributeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadAttributeGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, LeadAttribute attribute, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, LeadAttribute attribute, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}