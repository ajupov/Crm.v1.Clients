using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Products.Models;
using Crm.v1.Clients.Clients.Products.Requests;
using Crm.v1.Clients.Clients.Products.Responses;

namespace Crm.v1.Clients.Clients.Products.Clients
{
    public interface IProductsClient
    {
        Task<Product> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<Product>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<ProductGetPagedListResponse> GetPagedListAsync(
            ProductGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(Product product, Dictionary<string, string> headers, CancellationToken ct = default);

        Task UpdateAsync(Product product, Dictionary<string, string> headers, CancellationToken ct = default);

        Task HideAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task ShowAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
