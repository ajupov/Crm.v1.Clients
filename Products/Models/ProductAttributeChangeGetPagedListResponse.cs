using System.Collections.Generic;

namespace Crm.v1.Clients.Products.Models
{
    public class ProductAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductAttributeChange> Changes { get; set; }
    }
}
