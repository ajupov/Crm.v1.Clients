using System;

namespace Crm.v1.Clients.Clients.User.Models
{
    public class UserSetting
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }
    }
}
