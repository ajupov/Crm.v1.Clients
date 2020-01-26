using System;

namespace Crm.v1.Clients.Activities.Models
{
    public class ActivityAttributeChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid AttributeId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}