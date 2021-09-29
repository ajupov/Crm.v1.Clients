using System.Collections.Generic;
using Crm.v1.Clients.Customers.Models;

namespace Crm.v1.Clients.Customers.Responses
{
    public class CustomerCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<CustomerComment> Comments { get; set; }
    }
}
