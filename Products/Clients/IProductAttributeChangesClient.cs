using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Models;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductAttributeChangesClient
    {
        Task<ProductAttributeChangeGetPagedListResponse> GetPagedListAsync(
            ProductAttributeChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
