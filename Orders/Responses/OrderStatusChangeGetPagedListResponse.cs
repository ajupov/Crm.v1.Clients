using System.Collections.Generic;
using Crm.v1.Clients.Orders.Models;

namespace Crm.v1.Clients.Orders.Responses
{
    public class OrderStatusChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<OrderStatusChange> Changes { get; set; }
    }
}
