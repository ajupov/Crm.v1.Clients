using System.Collections.Generic;
using Crm.v1.Clients.Orders.Models;

namespace Crm.v1.Clients.Orders.Responses
{
    public class OrderChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<OrderChange> Changes { get; set; }
    }
}
