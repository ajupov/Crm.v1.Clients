using System.Collections.Generic;
using Crm.V1.Clients.Activities.Models;

namespace Crm.V1.Clients.Activities.Responses
{
    public class ActivityTypeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ActivityTypeChange> Changes { get; set; }
    }
}
