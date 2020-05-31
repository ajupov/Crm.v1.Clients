namespace Crm.V1.Clients.Companies.Models
{
    public class CompanyBankAccount
    {
        public string Number { get; set; }

        public string BankNumber { get; set; }

        public string BankCorrespondentNumber { get; set; }

        public string BankName { get; set; }

        public bool IsDeleted { get; set; }
    }
}
