using System.Collections.Generic;
using Crm.V1.Clients.Deals.Models;

namespace Crm.V1.Clients.Deals.Responses
{
    public class DealChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<DealChange> Changes { get; set; }
    }
}
