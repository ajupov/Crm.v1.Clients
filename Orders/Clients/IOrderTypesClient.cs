using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Orders.Models;
using Crm.v1.Clients.Orders.Requests;
using Crm.v1.Clients.Orders.Responses;

namespace Crm.v1.Clients.Orders.Clients
{
    public interface IOrderTypesClient
    {
        Task<OrderType> GetAsync(Guid id, Dictionary<string, string> headers = default, CancellationToken ct = default);

        Task<List<OrderType>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<OrderTypeGetPagedListResponse> GetPagedListAsync(
            OrderTypeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            OrderType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task UpdateAsync(OrderType type, Dictionary<string, string> headers = default, CancellationToken ct = default);

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
