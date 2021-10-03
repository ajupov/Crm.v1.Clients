using System.Collections.Generic;

namespace Crm.v1.Clients.Products.Models
{
    public class ProductChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductChange> Changes { get; set; }
    }
}
