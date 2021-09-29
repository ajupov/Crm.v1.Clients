using System;
using Crm.Common.All.Types.AttributeType;

namespace Crm.v1.Clients.Customers.Models
{
    public class CustomerAttribute
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public AttributeType Type { get; set; }

        public string Key { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }
    }
}
