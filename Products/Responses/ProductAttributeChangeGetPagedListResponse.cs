using System.Collections.Generic;
using Crm.V1.Clients.Products.Models;

namespace Crm.V1.Clients.Products.Responses
{
    public class ProductAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductAttributeChange> Changes { get; set; }
    }
}
