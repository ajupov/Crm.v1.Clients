using System.Collections.Generic;
using Crm.v1.Clients.Products.Models;

namespace Crm.v1.Clients.Products.Responses
{
    public class ProductCategoryChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductCategoryChange> Changes { get; set; }
    }
}
