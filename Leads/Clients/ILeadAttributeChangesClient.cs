using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Leads.Models;
using Crm.v1.Clients.Leads.RequestParameters;

namespace Crm.v1.Clients.Leads.Clients
{
    public interface ILeadAttributeChangesClient
    {
        Task<List<LeadAttributeChange>> GetPagedListAsync(
            string accessToken,
            LeadAttributeChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}