using System.Collections.Generic;
using Crm.V1.Clients.Deals.Models;

namespace Crm.V1.Clients.Deals.Responses
{
    public class DealCommentGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<DealComment> Comments { get; set; }
    }
}
