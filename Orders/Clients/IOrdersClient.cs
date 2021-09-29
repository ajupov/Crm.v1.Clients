using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Orders.Models;
using Crm.v1.Clients.Orders.Requests;
using Crm.v1.Clients.Orders.Responses;

namespace Crm.v1.Clients.Orders.Clients
{
    public interface IOrdersClient
    {
        Task<Order> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<Order>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<OrderGetPagedListResponse> GetPagedListAsync(
            OrderGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(Order order, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(Order order, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
