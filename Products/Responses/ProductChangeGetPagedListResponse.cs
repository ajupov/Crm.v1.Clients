using System.Collections.Generic;
using Crm.V1.Clients.Products.Models;

namespace Crm.V1.Clients.Products.Responses
{
    public class ProductChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductChange> Changes { get; set; }
    }
}
