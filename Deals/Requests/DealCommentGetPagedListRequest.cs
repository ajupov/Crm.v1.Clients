using System;

namespace Crm.V1.Clients.Deals.Requests
{
    public class DealCommentGetPagedListRequest
    {
        public Guid DealId { get; set; }

        public DateTime? CommentGetPagedListRequest { get; set; }

        public DateTime? AfterCreateDateTime { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
