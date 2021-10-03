using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<OrderAttribute> Attributes { get; set; }
    }
}
