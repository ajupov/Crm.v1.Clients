using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Activities.Models;
using Crm.V1.Clients.Activities.Requests;
using Crm.V1.Clients.Activities.Responses;

namespace Crm.V1.Clients.Activities.Clients
{
    public interface IActivityCommentsClient
    {
        Task<ActivityCommentGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ActivityCommentGetPagedListRequest request,
            CancellationToken ct = default);

        Task CreateAsync(string accessToken, ActivityComment comment, CancellationToken ct = default);
    }
}
