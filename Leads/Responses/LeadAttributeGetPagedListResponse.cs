using System;
using System.Collections.Generic;
using Crm.V1.Clients.Leads.Models;

namespace Crm.V1.Clients.Leads.Responses
{
    public class LeadAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<LeadAttribute> Attributes { get; set; }
    }
}
