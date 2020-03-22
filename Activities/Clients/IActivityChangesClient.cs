using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Activities.Requests;
using Crm.v1.Clients.Activities.Responses;

namespace Crm.v1.Clients.Activities.Clients
{
    public interface IActivityChangesClient
    {
        Task<ActivityChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}