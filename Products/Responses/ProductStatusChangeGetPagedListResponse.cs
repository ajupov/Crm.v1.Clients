using System.Collections.Generic;
using Crm.V1.Clients.Products.Models;

namespace Crm.V1.Clients.Products.Responses
{
    public class ProductStatusChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ProductStatusChange> Changes { get; set; }
    }
}
