using System;
using System.Collections.Generic;
using Crm.v1.Clients.Companies.Models;

namespace Crm.v1.Clients.Companies.Requests
{
    public class CompanyGetPagedListRequest
    {
        public Guid? LeadId { get; set; }

        public string FullName { get; set; }

        public string ShortName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string TaxNumber { get; set; }

        public string RegistrationNumber { get; set; }

        public DateTime? MinRegistrationDate { get; set; }

        public DateTime? MaxRegistrationDate { get; set; }

        public int? MinEmployeesCount { get; set; }

        public int? MaxEmployeesCount { get; set; }

        public decimal? MinYearlyTurnover { get; set; }

        public decimal? MaxYearlyTurnover { get; set; }

        public string JuridicalPostcode { get; set; }

        public string JuridicalCountry { get; set; }

        public string JuridicalRegion { get; set; }

        public string JuridicalProvince { get; set; }

        public string JuridicalCity { get; set; }

        public string JuridicalStreet { get; set; }

        public string JuridicalHouse { get; set; }

        public string JuridicalApartment { get; set; }

        public string LegalPostcode { get; set; }

        public string LegalCountry { get; set; }

        public string LegalRegion { get; set; }

        public string LegalProvince { get; set; }

        public string LegalCity { get; set; }

        public string LegalStreet { get; set; }

        public string LegalHouse { get; set; }

        public string LegalApartment { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public DateTime? MinModifyDate { get; set; }

        public DateTime? MaxModifyDate { get; set; }

        public List<CompanyType> Types { get; set; }

        public List<CompanyIndustryType> IndustryTypes { get; set; }

        public bool? AllAttributes { get; set; }

        public Dictionary<Guid, string> Attributes { get; set; }

        public string BankAccountNumber { get; set; }

        public string BankAccountBankNumber { get; set; }

        public string BankAccountBankCorrespondentNumber { get; set; }

        public string BankAccountBankName { get; set; }

        public List<Guid> CreateUserIds { get; set; }

        public List<Guid> ResponsibleUserIds { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}