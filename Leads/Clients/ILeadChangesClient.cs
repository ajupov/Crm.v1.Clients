using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Leads.Models;
using Crm.v1.Clients.Leads.RequestParameters;

namespace Crm.v1.Clients.Leads.Clients
{
    public interface ILeadChangesClient
    {
        Task<List<LeadChange>> GetPagedListAsync(
            string accessToken,
            LeadChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}