using System;
using System.Collections.Generic;
using Crm.v1.Clients.Customers.Models;

namespace Crm.v1.Clients.Customers.Responses
{
    public class CustomerAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<CustomerAttribute> Attributes { get; set; }
    }
}
