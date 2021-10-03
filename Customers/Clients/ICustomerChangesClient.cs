using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Customers.Models;

namespace Crm.v1.Clients.Customers.Clients
{
    public interface ICustomerChangesClient
    {
        Task<CustomerChangeGetPagedListResponse> GetPagedListAsync(
            CustomerChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
