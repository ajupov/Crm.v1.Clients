using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Deals.Requests;
using Crm.v1.Clients.Deals.Responses;

namespace Crm.v1.Clients.Deals.Clients
{
    public interface IDealTypeChangesClient
    {
        Task<DealTypeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            DealTypeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}