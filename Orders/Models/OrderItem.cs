using System;
using System.Text.Json.Serialization;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderItem
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductVendorCode { get; set; }

        public decimal Price { get; set; }

        public decimal Count { get; set; }
    }
}
