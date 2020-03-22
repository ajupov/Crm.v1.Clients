using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Requests;
using Crm.v1.Clients.Products.Responses;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductCategoryChangesClient
    {
        Task<ProductCategoryChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductCategoryChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}