using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Orders.Models;
using Crm.v1.Clients.Orders.Requests;
using Crm.v1.Clients.Orders.Responses;

namespace Crm.v1.Clients.Orders.Clients
{
    public interface IOrderStatusesClient
    {
        Task<OrderStatus> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<List<OrderStatus>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<OrderStatusGetPagedListResponse> GetPagedListAsync(
            OrderStatusGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            OrderStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task UpdateAsync(
            OrderStatus status,
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
