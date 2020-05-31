using System;

namespace Crm.V1.Clients.Leads.Models
{
    public class LeadSourceChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid SourceId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
