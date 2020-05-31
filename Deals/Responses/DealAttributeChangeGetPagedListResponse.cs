using System.Collections.Generic;
using Crm.V1.Clients.Deals.Models;

namespace Crm.V1.Clients.Deals.Responses
{
    public class DealAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<DealAttributeChange> Changes { get; set; }
    }
}
