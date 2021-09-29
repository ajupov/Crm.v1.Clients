using System.Collections.Generic;
using Crm.v1.Clients.Clients.Tasks.Models;

namespace Crm.v1.Clients.Clients.Tasks.Responses
{
    public class ActivityAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ActivityAttributeChange> Changes { get; set; }
    }
}
