using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Customers.Models
{
    public class CustomerAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<CustomerAttribute> Attributes { get; set; }
    }
}
