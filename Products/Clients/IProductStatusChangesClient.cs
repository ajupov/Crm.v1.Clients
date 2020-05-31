using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Products.Requests;
using Crm.V1.Clients.Products.Responses;

namespace Crm.V1.Clients.Products.Clients
{
    public interface IProductStatusChangesClient
    {
        Task<ProductStatusChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductStatusChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
