using System;
using System.Collections.Generic;

namespace Crm.V1.Clients.Companies.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid LeadId { get; set; }

        public Guid CreateUserId { get; set; }

        public Guid? ResponsibleUserId { get; set; }

        public CompanyType Type { get; set; }

        public CompanyIndustryType IndustryType { get; set; }

        public string FullName { get; set; }

        public string ShortName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string TaxNumber { get; set; }

        public string RegistrationNumber { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public int EmployeesCount { get; set; }

        public decimal YearlyTurnover { get; set; }

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

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public List<CompanyBankAccount> BankAccounts { get; set; }

        public List<CompanyAttributeLink> AttributeLinks { get; set; }
    }
}
