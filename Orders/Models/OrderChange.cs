using System;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid OrderId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
