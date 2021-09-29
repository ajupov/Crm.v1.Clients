using System;
using System.Collections.Generic;
using Crm.v1.Clients.Products.Models;

namespace Crm.v1.Clients.Products.Responses
{
    public class ProductGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<Product> Products { get; set; }
    }
}
