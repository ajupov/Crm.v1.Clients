﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Products.Models;
using Crm.V1.Clients.Products.Requests;
using Crm.V1.Clients.Products.Responses;

namespace Crm.V1.Clients.Products.Clients
{
    public interface IProductsClient
    {
        Task<Dictionary<string, ProductType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<Product> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<Product>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<ProductGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, Product product, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, Product product, CancellationToken ct = default);

        Task HideAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task ShowAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}
