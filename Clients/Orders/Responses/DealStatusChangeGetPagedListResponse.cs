using System.Collections.Generic;
using Crm.v1.Clients.Clients.Orders.Models;

namespace Crm.v1.Clients.Clients.Orders.Responses
{
    public class DealStatusChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<DealStatusChange> Changes { get; set; }
    }
}
