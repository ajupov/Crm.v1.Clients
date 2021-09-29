using System;
using System.Collections.Generic;
using Crm.v1.Clients.Clients.Tasks.Models;

namespace Crm.v1.Clients.Clients.Tasks.Responses
{
    public class ActivityGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<Activity> Activities { get; set; }
    }
}
