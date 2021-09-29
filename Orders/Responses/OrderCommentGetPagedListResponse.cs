using System.Collections.Generic;
using Crm.v1.Clients.Orders.Models;

namespace Crm.v1.Clients.Orders.Responses
{
    public class OrderCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<OrderComment> Comments { get; set; }
    }
}
