using System.Collections.Generic;
using Crm.v1.Clients.Clients.Tasks.Models;

namespace Crm.v1.Clients.Clients.Tasks.Responses
{
    public class ActivityCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<ActivityComment> Comments { get; set; }
    }
}
