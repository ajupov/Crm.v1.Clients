using System.Collections.Generic;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<OrderComment> Comments { get; set; }
    }
}
