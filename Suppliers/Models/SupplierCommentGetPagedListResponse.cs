using System.Collections.Generic;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<SupplierComment> Comments { get; set; }
    }
}
