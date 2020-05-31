using System;

namespace Crm.V1.Clients.Deals.Models
{
    public class DealStatus
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public string Name { get; set; }

        public bool IsFinish { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }
    }
}
