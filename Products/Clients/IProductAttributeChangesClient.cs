﻿using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Requests;
using Crm.v1.Clients.Products.Responses;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductAttributeChangesClient
    {
        Task<ProductAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}