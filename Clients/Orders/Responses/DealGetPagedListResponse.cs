using System;
using System.Collections.Generic;
using Crm.v1.Clients.Clients.Orders.Models;

namespace Crm.v1.Clients.Clients.Orders.Responses
{
    public class DealGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<Deal> Deals { get; set; }
    }
}
