using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Products.Models;
using Crm.v1.Clients.Clients.Products.Requests;
using Crm.v1.Clients.Clients.Products.Responses;

namespace Crm.v1.Clients.Clients.Products.Clients
{
    public interface IProductStatusesClient
    {
        Task<ProductStatus> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<ProductStatus>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<ProductStatusGetPagedListResponse> GetPagedListAsync(
            ProductStatusGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(ProductStatus group, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(ProductStatus group, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
