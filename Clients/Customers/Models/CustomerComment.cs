using System;

namespace Crm.v1.Clients.Clients.Customers.Models
{
    public class CustomerComment
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public Guid CommentatorUserId { get; set; }

        public string Value { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
