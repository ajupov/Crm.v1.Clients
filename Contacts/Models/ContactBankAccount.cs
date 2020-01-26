namespace Crm.v1.Clients.Contacts.Models
{
    public class ContactBankAccount
    {
        public string Number { get; set; }

        public string BankNumber { get; set; }

        public string BankCorrespondentNumber { get; set; }

        public string BankName { get; set; }

        public bool IsDeleted { get; set; }
    }
}