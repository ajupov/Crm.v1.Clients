using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<Supplier> Suppliers { get; set; }
    }
}
