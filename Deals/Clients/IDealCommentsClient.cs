using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Deals.Models;
using Crm.v1.Clients.Deals.RequestParameters;

namespace Crm.v1.Clients.Deals.Clients
{
    public interface IDealCommentsClient
    {
        Task<List<DealComment>> GetPagedListAsync(
            string accessToken,
            DealCommentGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task CreateAsync(string accessToken, DealComment comment, CancellationToken ct = default);
    }
}