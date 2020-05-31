using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Deals.Requests;
using Crm.V1.Clients.Deals.Responses;

namespace Crm.V1.Clients.Deals.Clients
{
    public interface IDealTypeChangesClient
    {
        Task<DealTypeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            DealTypeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
