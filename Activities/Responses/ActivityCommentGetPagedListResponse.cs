using System.Collections.Generic;
using Crm.V1.Clients.Activities.Models;

namespace Crm.V1.Clients.Activities.Responses
{
    public class ActivityCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<ActivityComment> Comments { get; set; }
    }
}
