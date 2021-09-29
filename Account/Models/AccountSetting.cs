using System;

namespace Crm.v1.Clients.Account.Models
{
    public class AccountSetting
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }
    }
}
