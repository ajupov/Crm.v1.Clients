using System;
using System.Collections.Generic;
using Crm.V1.Clients.Leads.Models;

namespace Crm.V1.Clients.Leads.Responses
{
    public class LeadSourceGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<LeadSource> Sources { get; set; }
    }
}
