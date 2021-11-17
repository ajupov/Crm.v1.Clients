using System.Collections.Generic;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<SupplierAttributeChange> Changes { get; set; }
    }
}
