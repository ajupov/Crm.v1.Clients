using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Customers.Models;

namespace Crm.v1.Clients.Customers.Clients
{
    public interface ICustomerCommentsClient
    {
        Task<CustomerCommentGetPagedListResponse> GetPagedListAsync(
            CustomerCommentGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task CreateAsync(
            CustomerComment comment,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
