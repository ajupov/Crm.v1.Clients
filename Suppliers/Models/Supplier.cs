using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class Supplier
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid? CreateUserId { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public List<SupplierAttributeLink> AttributeLinks { get; set; }
    }
}
