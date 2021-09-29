using System.Collections.Generic;
using Crm.v1.Clients.Products.Models;

namespace Crm.v1.Clients.Products.Responses
{
    public class ProductChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductChange> Changes { get; set; }
    }
}
