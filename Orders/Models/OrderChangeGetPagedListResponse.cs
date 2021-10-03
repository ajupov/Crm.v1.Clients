using System.Collections.Generic;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<OrderChange> Changes { get; set; }
    }
}
