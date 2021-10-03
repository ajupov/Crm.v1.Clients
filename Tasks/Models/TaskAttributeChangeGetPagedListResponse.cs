using System.Collections.Generic;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<TaskAttributeChange> Changes { get; set; }
    }
}
