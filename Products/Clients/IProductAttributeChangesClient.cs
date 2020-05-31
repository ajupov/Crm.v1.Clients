using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Products.Requests;
using Crm.V1.Clients.Products.Responses;

namespace Crm.V1.Clients.Products.Clients
{
    public interface IProductAttributeChangesClient
    {
        Task<ProductAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
