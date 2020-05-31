using System;

namespace Crm.V1.Clients.Products.Models
{
    public class ProductChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid ProductId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
