using System;
using System.Collections.Generic;

namespace Crm.V1.Clients.Leads.Models
{
    public class Lead
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid SourceId { get; set; }

        public Guid CreateUserId { get; set; }

        public Guid? ResponsibleUserId { get; set; }

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

        public decimal OpportunitySum { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public LeadSource Source { get; set; }

        public List<LeadAttributeLink> AttributeLinks { get; set; }
    }
}
