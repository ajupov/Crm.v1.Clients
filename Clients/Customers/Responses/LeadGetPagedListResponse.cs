using System;
using System.Collections.Generic;
using Crm.v1.Clients.Clients.Customers.Models;

namespace Crm.v1.Clients.Clients.Customers.Responses
{
    public class LeadGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<Lead> Leads { get; set; }
    }
}
