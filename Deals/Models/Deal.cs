using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Deals.Models
{
    public class Deal
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid TypeId { get; set; }

        public Guid StatusId { get; set; }

        public Guid? CompanyId { get; set; }

        public Guid? ContactId { get; set; }

        public Guid CreateUserId { get; set; }

        public Guid? ResponsibleUserId { get; set; }

        public string Name { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public decimal Sum { get; set; }

        public decimal SumWithoutDiscount { get; set; }

        public byte FinishProbability { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public DealType Type { get; set; }

        public DealStatus Status { get; set; }

        public List<DealPosition> Positions { get; set; }

        public List<DealAttributeLink> AttributeLinks { get; set; }
    }
}