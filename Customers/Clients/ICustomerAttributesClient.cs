using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Customers.Models;

namespace Crm.v1.Clients.Customers.Clients
{
    public interface ICustomerAttributesClient
    {
        Task<CustomerAttribute> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<List<CustomerAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<CustomerAttributeGetPagedListResponse> GetPagedListAsync(
            CustomerAttributeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            CustomerAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task UpdateAsync(
            CustomerAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
