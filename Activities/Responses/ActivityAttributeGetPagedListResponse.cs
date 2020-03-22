using System;
using System.Collections.Generic;
using Crm.v1.Clients.Activities.Models;

namespace Crm.v1.Clients.Activities.Responses
{
    public class ActivityAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<ActivityAttribute> Attributes { get; set; }
    }
}