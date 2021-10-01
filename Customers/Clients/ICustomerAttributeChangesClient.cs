using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Customers.Requests;
using Crm.v1.Clients.Customers.Responses;

namespace Crm.v1.Clients.Customers.Clients
{
    public interface ICustomerAttributeChangesClient
    {
        Task<CustomerAttributeChangeGetPagedListResponse> GetPagedListAsync(
            CustomerAttributeChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
