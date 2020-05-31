using System.Collections.Generic;
using Crm.V1.Clients.Deals.Models;

namespace Crm.V1.Clients.Deals.Responses
{
    public class DealStatusChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<DealStatusChange> Changes { get; set; }
    }
}
