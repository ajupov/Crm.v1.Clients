using System.Collections.Generic;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskStatusChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<TaskStatusChange> Changes { get; set; }
    }
}
