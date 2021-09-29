using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Orders.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid TypeId { get; set; }

        public Guid StatusId { get; set; }

        public Guid CreateUserId { get; set; }

        public Guid? ResponsibleUserId { get; set; }

        public Guid CustomerId { get; set; }

        public string Name { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public decimal Sum { get; set; }

        public decimal SumWithoutDiscount { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public OrderType Type { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; }

        public List<OrderAttributeLink> AttributeLinks { get; set; }
    }
}
