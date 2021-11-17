using System;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierComment
    {
        public Guid Id { get; set; }

        public Guid SupplierId { get; set; }

        public Guid CommentatorUserId { get; set; }

        public string Value { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
