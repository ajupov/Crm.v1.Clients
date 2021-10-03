using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Customers.Models
{
    public class CustomerSourceGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<CustomerSource> Sources { get; set; }
    }
}
