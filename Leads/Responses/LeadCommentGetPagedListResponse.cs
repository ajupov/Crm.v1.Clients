using System.Collections.Generic;
using Crm.V1.Clients.Leads.Models;

namespace Crm.V1.Clients.Leads.Responses
{
    public class LeadCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<LeadComment> Comments { get; set; }
    }
}
