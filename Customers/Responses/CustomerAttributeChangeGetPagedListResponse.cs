using System.Collections.Generic;
using Crm.v1.Clients.Customers.Models;

namespace Crm.v1.Clients.Customers.Responses
{
    public class CustomerAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<CustomerAttributeChange> Changes { get; set; }
    }
}
