using System;

namespace Crm.v1.Clients.Leads.Models
{
    public class LeadChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid LeadId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}