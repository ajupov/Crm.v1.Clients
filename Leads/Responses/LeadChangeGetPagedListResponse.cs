using System.Collections.Generic;
using Crm.v1.Clients.Leads.Models;

namespace Crm.v1.Clients.Leads.Responses
{
    public class LeadChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<LeadChange> Changes { get; set; }
    }
}