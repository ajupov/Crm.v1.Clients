using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Orders.Models;

namespace Crm.v1.Clients.Orders.Clients
{
    public interface IOrderAttributesClient
    {
        Task<OrderAttribute> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<List<OrderAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<OrderAttributeGetPagedListResponse> GetPagedListAsync(
            OrderAttributeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            OrderAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task UpdateAsync(
            OrderAttribute attribute,
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
