using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Deals.Requests;
using Crm.v1.Clients.Deals.Responses;

namespace Crm.v1.Clients.Deals.Clients
{
    public interface IDealChangesClient
    {
        Task<DealChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            DealChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}