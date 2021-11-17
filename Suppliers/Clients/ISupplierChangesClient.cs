using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Suppliers.Models;

namespace Crm.v1.Clients.Suppliers.Clients
{
    public interface ISupplierChangesClient
    {
        Task<SupplierChangeGetPagedListResponse> GetPagedListAsync(
            SupplierChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
