using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Requests;
using Crm.v1.Clients.Products.Responses;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductChangesClient
    {
        Task<ProductChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}