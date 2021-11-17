using System;
using System.Text.Json.Serialization;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierAttributeLink
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Guid SupplierId { get; set; }

        public Guid SupplierAttributeId { get; set; }

        public string Value { get; set; }
    }
}
