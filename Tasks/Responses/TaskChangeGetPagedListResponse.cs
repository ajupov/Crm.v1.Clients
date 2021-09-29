using System.Collections.Generic;
using Crm.v1.Clients.Tasks.Models;

namespace Crm.v1.Clients.Tasks.Responses
{
    public class TaskChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<TaskChange> Changes { get; set; }
    }
}
