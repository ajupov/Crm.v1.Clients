using System.Collections.Generic;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskTypeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<TaskTypeChange> Changes { get; set; }
    }
}
