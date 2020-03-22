using System;
using System.Collections.Generic;
using Crm.v1.Clients.Activities.Models;

namespace Crm.v1.Clients.Activities.Responses
{
    public class ActivityTypeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<ActivityType> Types { get; set; }
    }
}