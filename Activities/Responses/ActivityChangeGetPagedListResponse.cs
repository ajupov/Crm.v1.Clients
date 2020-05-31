using System.Collections.Generic;
using Crm.V1.Clients.Activities.Models;

namespace Crm.V1.Clients.Activities.Responses
{
    public class ActivityChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ActivityChange> Changes { get; set; }
    }
}
