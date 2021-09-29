using System.Collections.Generic;
using Crm.v1.Clients.Clients.Products.Models;

namespace Crm.v1.Clients.Clients.Products.Responses
{
    public class ProductAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductAttributeChange> Changes { get; set; }
    }
}
