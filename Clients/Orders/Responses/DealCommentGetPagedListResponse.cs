using System.Collections.Generic;
using Crm.v1.Clients.Clients.Orders.Models;

namespace Crm.v1.Clients.Clients.Orders.Responses
{
    public class DealCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<DealComment> Comments { get; set; }
    }
}
