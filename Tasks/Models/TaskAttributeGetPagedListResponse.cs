using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<TaskAttribute> Attributes { get; set; }
    }
}
