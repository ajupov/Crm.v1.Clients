using System;
using System.Collections.Generic;
using Crm.v1.Clients.Leads.Models;

namespace Crm.v1.Clients.Leads.Responses
{
    public class LeadSourceGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<LeadSource> Sources { get; set; }
    }
}