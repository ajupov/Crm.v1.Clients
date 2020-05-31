using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Activities.Requests;
using Crm.V1.Clients.Activities.Responses;

namespace Crm.V1.Clients.Activities.Clients
{
    public interface IActivityChangesClient
    {
        Task<ActivityChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
