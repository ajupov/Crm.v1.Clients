using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Products.Requests;
using Crm.v1.Clients.Clients.Products.Responses;

namespace Crm.v1.Clients.Clients.Products.Clients
{
    public interface IProductCategoryChangesClient
    {
        Task<ProductCategoryChangeGetPagedListResponse> GetPagedListAsync(
            ProductCategoryChangeGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);
    }
}
