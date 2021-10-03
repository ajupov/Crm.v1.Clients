using System.Collections.Generic;

namespace Crm.v1.Clients.Customers.Models
{
    public class CustomerSourceChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<CustomerSourceChange> Changes { get; set; }
    }
}
