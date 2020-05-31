using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Deals.Models;
using Crm.V1.Clients.Deals.Requests;
using Crm.V1.Clients.Deals.Responses;

namespace Crm.V1.Clients.Deals.Clients
{
    public interface IDealCommentsClient
    {
        Task<DealCommentGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            DealCommentGetPagedListRequest request,
            CancellationToken ct = default);

        Task CreateAsync(string accessToken, DealComment comment, CancellationToken ct = default);
    }
}
