using System.Collections.Generic;

namespace Crm.v1.Clients.Customers.Models
{
    public class CustomerAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<CustomerAttributeChange> Changes { get; set; }
    }
}
