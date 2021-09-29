using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Models;
using Crm.v1.Clients.Products.Requests;
using Crm.v1.Clients.Products.Responses;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductCategoriesClient
    {
        Task<ProductCategory> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<ProductCategory>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<ProductCategoryGetPagedListResponse> GetPagedListAsync(
            ProductCategoryGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            ProductCategory group,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task UpdateAsync(ProductCategory group, Dictionary<string, string> headers, CancellationToken ct = default);

        Task DeleteAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);

        Task RestoreAsync(IEnumerable<Guid> ids, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
