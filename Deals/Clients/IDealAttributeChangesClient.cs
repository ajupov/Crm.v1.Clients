using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Deals.Requests;
using Crm.V1.Clients.Deals.Responses;

namespace Crm.V1.Clients.Deals.Clients
{
    public interface IDealAttributeChangesClient
    {
        Task<DealAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            DealAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
