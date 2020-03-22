using System.Collections.Generic;
using Crm.v1.Clients.Companies.Models;

namespace Crm.v1.Clients.Companies.Responses
{
    public class CompanyCommentGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<CompanyComment> Comments { get; set; }
    }
}