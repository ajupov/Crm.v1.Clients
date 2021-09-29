using System;
using System.Text.Json.Serialization;

namespace Crm.v1.Clients.Clients.Customers.Models
{
    public class CustomerAttributeLink
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Guid CustomerId { get; set; }

        public Guid CustomerAttributeId { get; set; }

        public string Value { get; set; }
    }
}
