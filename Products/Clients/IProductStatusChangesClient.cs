using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Requests;
using Crm.v1.Clients.Products.Responses;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductStatusChangesClient
    {
        Task<ProductStatusChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductStatusChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}