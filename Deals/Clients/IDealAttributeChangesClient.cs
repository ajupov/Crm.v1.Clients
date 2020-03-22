using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Deals.Requests;
using Crm.v1.Clients.Deals.Responses;

namespace Crm.v1.Clients.Deals.Clients
{
    public interface IDealAttributeChangesClient
    {
        Task<DealAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            DealAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}