using System.Collections.Generic;
using Crm.V1.Clients.Companies.Models;

namespace Crm.V1.Clients.Companies.Responses
{
    public class CompanyChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<CompanyChange> Changes { get; set; }
    }
}
