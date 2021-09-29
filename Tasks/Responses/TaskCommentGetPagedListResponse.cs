using System.Collections.Generic;
using Crm.v1.Clients.Tasks.Models;

namespace Crm.v1.Clients.Tasks.Responses
{
    public class TaskCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<TaskComment> Comments { get; set; }
    }
}
