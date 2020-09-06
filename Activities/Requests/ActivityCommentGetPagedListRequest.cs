using System;

namespace Crm.V1.Clients.Activities.Requests
{
    public class ActivityCommentGetPagedListRequest
    {
        public Guid ActivityId { get; set; }

        public DateTime? AfterCreateDateTime { get; set; }

        public int Limit { get; set; } = 10;
    }
}
