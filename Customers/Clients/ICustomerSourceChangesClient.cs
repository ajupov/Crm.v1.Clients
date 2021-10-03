using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Customers.Models;

namespace Crm.v1.Clients.Customers.Clients
{
    public interface ICustomerSourceChangesClient
    {
        Task<CustomerSourceChangeGetPagedListResponse> GetPagedListAsync(
            CustomerSourceChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
