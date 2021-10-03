using System.Collections.Generic;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<TaskChange> Changes { get; set; }
    }
}
