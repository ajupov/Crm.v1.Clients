using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Products.Models
{
    public class ProductCategoryGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<ProductCategory> Categories { get; set; }
    }
}
