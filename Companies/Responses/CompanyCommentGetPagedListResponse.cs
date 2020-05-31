using System.Collections.Generic;
using Crm.V1.Clients.Companies.Models;

namespace Crm.V1.Clients.Companies.Responses
{
    public class CompanyCommentGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<CompanyComment> Comments { get; set; }
    }
}
