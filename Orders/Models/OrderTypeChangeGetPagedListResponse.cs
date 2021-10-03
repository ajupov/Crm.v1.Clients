using System.Collections.Generic;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderTypeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<OrderTypeChange> Changes { get; set; }
    }
}
