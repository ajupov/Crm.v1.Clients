using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Activities.Requests;
using Crm.V1.Clients.Activities.Responses;

namespace Crm.V1.Clients.Activities.Clients
{
    public interface IActivityAttributeChangesClient
    {
        Task<ActivityAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
