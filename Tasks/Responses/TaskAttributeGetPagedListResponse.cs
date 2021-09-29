using System;
using System.Collections.Generic;
using Crm.v1.Clients.Tasks.Models;

namespace Crm.v1.Clients.Tasks.Responses
{
    public class TaskAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<TaskAttribute> Attributes { get; set; }
    }
}
