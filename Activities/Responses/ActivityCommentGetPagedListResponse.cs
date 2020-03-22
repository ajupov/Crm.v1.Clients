using System.Collections.Generic;
using Crm.v1.Clients.Activities.Models;

namespace Crm.v1.Clients.Activities.Responses
{
    public class ActivityCommentGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ActivityComment> Comments { get; set; }
    }
}