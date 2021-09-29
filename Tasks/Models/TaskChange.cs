using System;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid TaskId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
