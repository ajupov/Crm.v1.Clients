using System.Collections.Generic;
using Crm.v1.Clients.Clients.Customers.Models;

namespace Crm.v1.Clients.Clients.Customers.Responses
{
    public class LeadSourceChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<LeadSourceChange> Changes { get; set; }
    }
}
