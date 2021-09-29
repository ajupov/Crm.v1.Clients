using System;
using System.Collections.Generic;
using Crm.v1.Clients.Orders.Models;

namespace Crm.v1.Clients.Orders.Responses
{
    public class OrderAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<OrderAttribute> Attributes { get; set; }
    }
}
