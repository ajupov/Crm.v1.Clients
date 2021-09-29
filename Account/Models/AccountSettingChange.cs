using System;

namespace Crm.v1.Clients.Account.Models
{
    public class AccountSettingChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid AccountId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
