using System;

namespace Crm.v1.Clients.Leads.Models
{
    public class LeadAttributeLink
    {
        public Guid LeadAttributeId { get; set; }

        public string Value { get; set; }
    }
}