using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<SupplierAttribute> Attributes { get; set; }
    }
}
