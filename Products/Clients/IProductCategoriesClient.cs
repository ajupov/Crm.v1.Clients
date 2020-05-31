using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Products.Models;
using Crm.V1.Clients.Products.Requests;
using Crm.V1.Clients.Products.Responses;

namespace Crm.V1.Clients.Products.Clients
{
    public interface IProductCategoriesClient
    {
        Task<ProductCategory> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<ProductCategory>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default);

        Task<ProductCategoryGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductCategoryGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, ProductCategory group, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, ProductCategory group, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}
