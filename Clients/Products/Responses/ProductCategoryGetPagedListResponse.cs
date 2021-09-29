using System;
using System.Collections.Generic;
using Crm.v1.Clients.Clients.Products.Models;

namespace Crm.v1.Clients.Clients.Products.Responses
{
    public class ProductCategoryGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<ProductCategory> Categories { get; set; }
    }
}
