using System;

namespace Crm.V1.Clients.Activities.Models
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
