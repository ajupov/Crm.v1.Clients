using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Leads.Requests;
using Crm.v1.Clients.Leads.Responses;

namespace Crm.v1.Clients.Leads.Clients
{
    public interface ILeadChangesClient
    {
        Task<LeadChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}