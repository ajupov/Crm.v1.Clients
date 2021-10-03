using System.Collections.Generic;

namespace Crm.v1.Clients.Products.Models
{
    public class ProductStatusChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductStatusChange> Changes { get; set; }
    }
}
