using System.Collections.Generic;

namespace Crm.v1.Clients.Products.Models
{
    public class ProductCategoryChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductCategoryChange> Changes { get; set; }
    }
}
