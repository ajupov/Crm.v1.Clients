using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Activities.Requests;
using Crm.v1.Clients.Activities.Responses;

namespace Crm.v1.Clients.Activities.Clients
{
    public interface IActivityTypeChangesClient
    {
        Task<ActivityTypeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityTypeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}