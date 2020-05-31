using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Leads.Requests;
using Crm.V1.Clients.Leads.Responses;

namespace Crm.V1.Clients.Leads.Clients
{
    public interface ILeadSourceChangesClient
    {
        Task<LeadSourceChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            LeadSourceChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
