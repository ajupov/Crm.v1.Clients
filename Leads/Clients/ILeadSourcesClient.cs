using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Leads.Models;
using Crm.V1.Clients.Leads.Requests;
using Crm.V1.Clients.Leads.Responses;

namespace Crm.V1.Clients.Leads.Clients
{
    public interface ILeadSourcesClient
    {
        Task<LeadSource> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<LeadSource>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<LeadSourceGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadSourceGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, LeadSource source, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, LeadSource source, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}
