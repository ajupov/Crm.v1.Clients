using System.Collections.Generic;

namespace Crm.v1.Clients.Customers.Models
{
    public class CustomerChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<CustomerChange> Changes { get; set; }
    }
}
