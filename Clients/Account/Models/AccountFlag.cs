using System;

namespace Crm.v1.Clients.Clients.Account.Models
{
    public class AccountFlag
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public AccountFlagType Type { get; set; }

        public DateTime SetDateTime { get; set; }
    }
}
