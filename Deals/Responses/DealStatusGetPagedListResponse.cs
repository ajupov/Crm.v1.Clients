using System;
using System.Collections.Generic;
using Crm.V1.Clients.Deals.Models;

namespace Crm.V1.Clients.Deals.Responses
{
    public class DealStatusGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<DealStatus> Statuses { get; set; }
    }
}
