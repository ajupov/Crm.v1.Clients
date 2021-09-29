using System;
using System.Collections.Generic;
using Crm.v1.Clients.Customers.Models;

namespace Crm.v1.Clients.Customers.Responses
{
    public class CustomerGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
