using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Requests;
using Crm.v1.Clients.Products.Responses;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductChangesClient
    {
        Task<ProductChangeGetPagedListResponse> GetPagedListAsync(
            ProductChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
