using System;
using System.Collections.Generic;
using Crm.v1.Clients.Companies.Models;

namespace Crm.v1.Clients.Companies.Responses
{
    public class CompanyAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<CompanyAttribute> Attributes { get; set; }
    }
}