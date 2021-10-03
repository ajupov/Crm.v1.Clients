using System.Collections.Generic;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<OrderAttributeChange> Changes { get; set; }
    }
}
