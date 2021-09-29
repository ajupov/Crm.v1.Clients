using System.Collections.Generic;
using Crm.v1.Clients.Tasks.Models;

namespace Crm.v1.Clients.Tasks.Responses
{
    public class TaskStatusChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<TaskStatusChange> Changes { get; set; }
    }
}
