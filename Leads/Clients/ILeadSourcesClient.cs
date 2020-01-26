using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Leads.Models;
using Crm.v1.Clients.Leads.RequestParameters;

namespace Crm.v1.Clients.Leads.Clients
{
    public interface ILeadSourcesClient
    {
        Task<LeadSource> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<LeadSource>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<List<LeadSource>> GetPagedListAsync(
            string accessToken,
            LeadSourceGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, LeadSource source, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, LeadSource source, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}