using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Activities.Models;
using Crm.v1.Clients.Activities.Requests;
using Crm.v1.Clients.Activities.Responses;

namespace Crm.v1.Clients.Activities.Clients
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