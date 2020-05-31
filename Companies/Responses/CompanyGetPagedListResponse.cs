using System;
using System.Collections.Generic;
using Crm.V1.Clients.Companies.Models;

namespace Crm.V1.Clients.Companies.Responses
{
    public class CompanyGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<Company> Companies { get; set; }
    }
}
