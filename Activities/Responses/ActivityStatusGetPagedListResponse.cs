using System;
using System.Collections.Generic;
using Crm.V1.Clients.Activities.Models;

namespace Crm.V1.Clients.Activities.Responses
{
    public class ActivityStatusGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<ActivityStatus> Statuses { get; set; }
    }
}
