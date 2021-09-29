using System.Collections.Generic;
using Crm.v1.Clients.Clients.Customers.Models;

namespace Crm.v1.Clients.Clients.Customers.Responses
{
    public class LeadChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<LeadChange> Changes { get; set; }
    }
}
