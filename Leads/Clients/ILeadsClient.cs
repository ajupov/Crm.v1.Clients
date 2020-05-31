using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Leads.Models;
using Crm.V1.Clients.Leads.Requests;
using Crm.V1.Clients.Leads.Responses;

namespace Crm.V1.Clients.Leads.Clients
{
    public interface ILeadsClient
    {
        Task<Lead> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<Lead>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<LeadGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, Lead lead, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, Lead lead, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}
