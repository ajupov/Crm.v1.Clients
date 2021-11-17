using System.Collections.Generic;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<SupplierChange> Changes { get; set; }
    }
}
