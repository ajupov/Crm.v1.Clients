using System;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid SupplierId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
