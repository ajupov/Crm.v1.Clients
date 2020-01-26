using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.Common.All.Types.AttributeType;
using Crm.v1.Clients.Products.Models;
using Crm.v1.Clients.Products.RequestParameters;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductAttributesClient
    {
        Task<Dictionary<string, AttributeType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<ProductAttribute> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<ProductAttribute>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default);

        Task<List<ProductAttribute>> GetPagedListAsync(
            string accessToken,
            ProductAttributeGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, ProductAttribute attribute, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, ProductAttribute attribute, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}