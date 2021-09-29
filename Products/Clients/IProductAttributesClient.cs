using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Models;
using Crm.v1.Clients.Products.Requests;
using Crm.v1.Clients.Products.Responses;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductAttributesClient
    {
        Task<ProductAttribute> GetAsync(
            Guid id,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<List<ProductAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<ProductAttributeGetPagedListResponse> GetPagedListAsync(
            ProductAttributeGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(
            ProductAttribute attribute,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task UpdateAsync(
            ProductAttribute attribute,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default);
    }
}
