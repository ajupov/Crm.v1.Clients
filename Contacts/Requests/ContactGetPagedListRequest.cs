using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Contacts.Requests
{
    public class ContactGetPagedListRequest
    {
        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string TaxNumber { get; set; }

        public string Post { get; set; }

        public string Postcode { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Apartment { get; set; }

        public DateTime? MinBirthDate { get; set; }

        public DateTime? MaxBirthDate { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public DateTime? MinModifyDate { get; set; }

        public DateTime? MaxModifyDate { get; set; }

        public bool? AllAttributes { get; set; }

        public Dictionary<Guid, string> Attributes { get; set; }

        public string BankAccountNumber { get; set; }

        public string BankAccountBankNumber { get; set; }

        public string BankAccountBankCorrespondentNumber { get; set; }

        public string BankAccountBankName { get; set; }

        public List<Guid> LeadIds { get; set; }

        public List<Guid> CompanyIds { get; set; }

        public List<Guid> CreateUserIds { get; set; }

        public List<Guid> ResponsibleUserIds { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}