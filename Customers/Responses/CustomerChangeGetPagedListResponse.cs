using System.Collections.Generic;
using Crm.v1.Clients.Customers.Models;

namespace Crm.v1.Clients.Customers.Responses
{
    public class CustomerChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<CustomerChange> Changes { get; set; }
    }
}
