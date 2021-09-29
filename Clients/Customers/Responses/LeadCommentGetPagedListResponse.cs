using System.Collections.Generic;
using Crm.v1.Clients.Clients.Customers.Models;

namespace Crm.v1.Clients.Clients.Customers.Responses
{
    public class LeadCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<LeadComment> Comments { get; set; }
    }
}
