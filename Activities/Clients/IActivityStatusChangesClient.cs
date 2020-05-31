using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Activities.Requests;
using Crm.V1.Clients.Activities.Responses;

namespace Crm.V1.Clients.Activities.Clients
{
    public interface IActivityStatusChangesClient
    {
        Task<ActivityStatusChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityStatusChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
