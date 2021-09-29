using System.Collections.Generic;
using Crm.v1.Clients.Clients.Tasks.Models;

namespace Crm.v1.Clients.Clients.Tasks.Responses
{
    public class ActivityTypeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ActivityTypeChange> Changes { get; set; }
    }
}
