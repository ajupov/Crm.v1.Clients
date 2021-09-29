using System;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskStatusChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid StatusId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
