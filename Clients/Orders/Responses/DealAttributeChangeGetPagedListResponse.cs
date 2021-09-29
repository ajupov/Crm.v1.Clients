using System.Collections.Generic;
using Crm.v1.Clients.Clients.Orders.Models;

namespace Crm.v1.Clients.Clients.Orders.Responses
{
    public class DealAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<DealAttributeChange> Changes { get; set; }
    }
}
