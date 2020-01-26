using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Activities.Models;
using Crm.v1.Clients.Activities.RequestParameters;

namespace Crm.v1.Clients.Activities.Clients
{
    public interface IActivityTypeChangesClient
    {
        Task<List<ActivityTypeChange>> GetPagedListAsync(
            string accessToken,
            ActivityTypeChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}