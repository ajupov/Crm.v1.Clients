using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Customers.Models
{
    public class CustomerGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
