using System;

namespace Crm.v1.Clients.Clients.Tasks.Requests
{
    public class ActivityCommentGetPagedListRequest
    {
        public Guid ActivityId { get; set; }

        public DateTime? CommentGetPagedListRequest { get; set; }

        public DateTime? AfterCreateDateTime { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
