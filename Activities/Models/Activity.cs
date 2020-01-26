using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Activities.Models
{
    public class Activity
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid TypeId { get; set; }

        public Guid StatusId { get; set; }

        public Guid? LeadId { get; set; }

        public Guid? CompanyId { get; set; }

        public Guid? ContactId { get; set; }

        public Guid? DealId { get; set; }

        public Guid CreateUserId { get; set; }

        public Guid? ResponsibleUserId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Result { get; set; }

        public ActivityPriority Priority { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public DateTime? DeadLineDateTime { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public ActivityType Type { get; set; }

        public ActivityStatus Status { get; set; }

        public List<ActivityAttributeLink> AttributeLinks { get; set; }
    }
}