using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Activities.Models;
using Crm.v1.Clients.Activities.RequestParameters;

namespace Crm.v1.Clients.Activities.Clients
{
    public interface IActivityStatusChangesClient
    {
        Task<List<ActivityStatusChange>> GetPagedListAsync(
            string accessToken,
            ActivityStatusChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}