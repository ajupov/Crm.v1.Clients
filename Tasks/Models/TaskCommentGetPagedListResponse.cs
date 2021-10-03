using System.Collections.Generic;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<TaskComment> Comments { get; set; }
    }
}
