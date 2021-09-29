using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Customers.Models;
using Crm.v1.Clients.Customers.Requests;
using Crm.v1.Clients.Customers.Responses;

namespace Crm.v1.Clients.Customers.Clients
{
    public interface ICustomerSourcesClient
    {
        Task<CustomerSource> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<CustomerSource>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<CustomerSourceGetPagedListResponse> GetPagedListAsync(
            CustomerSourceGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            CustomerSource source,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task UpdateAsync(CustomerSource source, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
