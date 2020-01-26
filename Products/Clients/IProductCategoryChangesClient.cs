using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Products.Models;
using Crm.v1.Clients.Products.RequestParameters;

namespace Crm.v1.Clients.Products.Clients
{
    public interface IProductCategoryChangesClient
    {
        Task<List<ProductCategoryChange>> GetPagedListAsync(
            string accessToken,
            ProductCategoryChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}