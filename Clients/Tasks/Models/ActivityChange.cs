using System;

namespace Crm.v1.Clients.Clients.Tasks.Models
{
    public class ActivityChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid ActivityId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
