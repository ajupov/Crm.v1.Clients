using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Leads.Requests;
using Crm.V1.Clients.Leads.Responses;

namespace Crm.V1.Clients.Leads.Clients
{
    public interface ILeadChangesClient
    {
        Task<LeadChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
