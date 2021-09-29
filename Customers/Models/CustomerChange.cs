using System;

namespace Crm.v1.Clients.Customers.Models
{
    public class CustomerChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
