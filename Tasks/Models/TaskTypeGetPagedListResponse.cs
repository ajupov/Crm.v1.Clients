using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskTypeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<TaskType> Types { get; set; }
    }
}
