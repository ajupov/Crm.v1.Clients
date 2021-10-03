using System.Collections.Generic;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderStatusChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<OrderStatusChange> Changes { get; set; }
    }
}
