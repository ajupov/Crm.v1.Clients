using System.Collections.Generic;

namespace Crm.v1.Clients.Customers.Models
{
    public class CustomerCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<CustomerComment> Comments { get; set; }
    }
}
