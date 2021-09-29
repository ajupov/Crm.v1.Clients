using System;
using System.Text.Json.Serialization;

namespace Crm.v1.Clients.Orders.Models
{
    public class OrderAttributeLink
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Guid OrderId { get; set; }

        public Guid OrderAttributeId { get; set; }

        public string Value { get; set; }
    }
}
