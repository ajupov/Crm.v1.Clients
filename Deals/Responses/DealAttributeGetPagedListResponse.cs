using System;
using System.Collections.Generic;
using Crm.v1.Clients.Deals.Models;

namespace Crm.v1.Clients.Deals.Responses
{
    public class DealAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<DealAttribute> Attributes { get; set; }
    }
}