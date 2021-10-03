using System;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderCommentGetPagedListRequest
    {
        public Guid OrderId { get; set; }

        public DateTime? BeforeCreateDateTime { get; set; }

        public DateTime? AfterCreateDateTime { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
