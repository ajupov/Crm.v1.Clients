using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Customers.Models;
using Crm.v1.Clients.Clients.Customers.Requests;
using Crm.v1.Clients.Clients.Customers.Responses;

namespace Crm.v1.Clients.Clients.Customers.Clients
{
    public interface ILeadSourcesClient
    {
        Task<LeadSource> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<LeadSource>> GetListAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<LeadSourceGetPagedListResponse> GetPagedListAsync(
            
            LeadSourceGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<Guid> CreateAsync(LeadSource source, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(LeadSource source, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
