using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Deals.Requests;
using Crm.v1.Clients.Deals.Responses;

namespace Crm.v1.Clients.Deals.Clients
{
    public interface IDealStatusChangesClient
    {
        Task<DealStatusChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            DealStatusChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}