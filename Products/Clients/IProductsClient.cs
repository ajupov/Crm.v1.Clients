using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Models;
using Crm.v1.Clients.Products.RequestParameters;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductsClient
    {
        Task<Dictionary<string, ProductType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<Product> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<Product>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<List<Product>> GetPagedListAsync(
            string accessToken,
            ProductGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, Product product, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, Product product, CancellationToken ct = default);

        Task HideAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task ShowAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}