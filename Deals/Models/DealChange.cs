using System;

namespace Crm.v1.Clients.Deals.Models
{
    public class DealChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid DealId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}