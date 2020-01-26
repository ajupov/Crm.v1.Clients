using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Leads.RequestParameters
{
    public class LeadGetPagedListRequestParameter
    {
        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string CompanyName { get; set; }

        public string Post { get; set; }

        public string Postcode { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Apartment { get; set; }

        public decimal? MinOpportunitySum { get; set; }

        public decimal? MaxOpportunitySum { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public DateTime? MinModifyDate { get; set; }

        public DateTime? MaxModifyDate { get; set; }

        public bool? AllAttributes { get; set; }

        public Dictionary<Guid, string> Attributes { get; set; }

        public List<Guid> SourceIds { get; set; }

        public List<Guid> CreateUserIds { get; set; }

        public List<Guid> ResponsibleUserIds { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}