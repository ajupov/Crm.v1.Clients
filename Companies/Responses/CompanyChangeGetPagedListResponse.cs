using System.Collections.Generic;
using Crm.v1.Clients.Companies.Models;

namespace Crm.v1.Clients.Companies.Responses
{
    public class CompanyChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<CompanyChange> Changes { get; set; }
    }
}