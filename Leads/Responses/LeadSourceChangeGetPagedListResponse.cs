using System.Collections.Generic;
using Crm.V1.Clients.Leads.Models;

namespace Crm.V1.Clients.Leads.Responses
{
    public class LeadSourceChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<LeadSourceChange> Changes { get; set; }
    }
}
