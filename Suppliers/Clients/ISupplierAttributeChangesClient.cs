using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Suppliers.Models;

namespace Crm.v1.Clients.Suppliers.Clients
{
    public interface ISupplierAttributeChangesClient
    {
        Task<SupplierAttributeChangeGetPagedListResponse> GetPagedListAsync(
            SupplierAttributeChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
