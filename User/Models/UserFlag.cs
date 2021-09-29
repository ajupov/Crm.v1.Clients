using System;

namespace Crm.v1.Clients.User.Models
{
    public class UserFlag
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public UserFlagType Type { get; set; }

        public DateTime SetDateTime { get; set; }
    }
}
