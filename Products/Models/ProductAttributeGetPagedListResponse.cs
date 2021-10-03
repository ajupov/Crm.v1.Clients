using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Products.Models
{
    public class ProductAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<ProductAttribute> Attributes { get; set; }
    }
}
