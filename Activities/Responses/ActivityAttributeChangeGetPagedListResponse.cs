using System.Collections.Generic;
using Crm.V1.Clients.Activities.Models;

namespace Crm.V1.Clients.Activities.Responses
{
    public class ActivityAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ActivityAttributeChange> Changes { get; set; }
    }
}
