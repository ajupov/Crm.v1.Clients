using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderTypeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<OrderType> Types { get; set; }
    }
}
