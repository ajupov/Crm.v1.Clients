using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Leads.Models;
using Crm.V1.Clients.Leads.Requests;
using Crm.V1.Clients.Leads.Responses;

namespace Crm.V1.Clients.Leads.Clients
{
    public interface ILeadCommentsClient
    {
        Task<LeadCommentGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadCommentGetPagedListRequest request,
            CancellationToken ct = default);

        Task CreateAsync(string accessToken, LeadComment comment, CancellationToken ct = default);
    }
}
