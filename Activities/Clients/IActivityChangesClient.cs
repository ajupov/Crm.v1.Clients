using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Activities.Models;
using Crm.v1.Clients.Activities.RequestParameters;

namespace Crm.v1.Clients.Activities.Clients
{
    public interface IActivityChangesClient
    {
        Task<List<ActivityChange>> GetPagedListAsync(
            string accessToken,
            ActivityChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}