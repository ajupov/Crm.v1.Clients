using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Customers.Models;
using Crm.v1.Clients.Clients.Customers.Requests;
using Crm.v1.Clients.Clients.Customers.Responses;

namespace Crm.v1.Clients.Clients.Customers.Clients
{
    public interface ILeadsClient
    {
        Task<Lead> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<Lead>> GetListAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<LeadGetPagedListResponse> GetPagedListAsync(
            
            LeadGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default);

        Task<Guid> CreateAsync(Lead lead, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(Lead lead, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
