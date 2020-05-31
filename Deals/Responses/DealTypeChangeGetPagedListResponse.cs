using System.Collections.Generic;
using Crm.V1.Clients.Deals.Models;

namespace Crm.V1.Clients.Deals.Responses
{
    public class DealTypeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<DealTypeChange> Changes { get; set; }
    }
}
