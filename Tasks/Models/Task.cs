using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Tasks.Models
{
    public class Task
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid TypeId { get; set; }

        public Guid StatusId { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid? OrderId { get; set; }

        public Guid CreateUserId { get; set; }

        public Guid? ResponsibleUserId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Result { get; set; }

        public TaskPriority Priority { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public DateTime? DeadLineDateTime { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public TaskType Type { get; set; }

        public TaskStatus Status { get; set; }

        public List<TaskAttributeLink> AttributeLinks { get; set; }
    }
}
