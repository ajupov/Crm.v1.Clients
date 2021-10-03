using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Models;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductStatusChangesClient
    {
        Task<ProductStatusChangeGetPagedListResponse> GetPagedListAsync(
            ProductStatusChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
