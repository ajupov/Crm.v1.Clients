using System.Collections.Generic;
using Crm.v1.Clients.Activities.Models;

namespace Crm.v1.Clients.Activities.Responses
{
    public class ActivityStatusChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ActivityStatusChange> Changes { get; set; }
    }
}