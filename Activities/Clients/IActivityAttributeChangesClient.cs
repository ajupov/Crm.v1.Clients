using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Activities.Requests;
using Crm.v1.Clients.Activities.Responses;

namespace Crm.v1.Clients.Activities.Clients
{
    public interface IActivityAttributeChangesClient
    {
        Task<ActivityAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}