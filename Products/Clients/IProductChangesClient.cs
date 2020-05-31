using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Products.Requests;
using Crm.V1.Clients.Products.Responses;

namespace Crm.V1.Clients.Products.Clients
{
    public interface IProductChangesClient
    {
        Task<ProductChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
