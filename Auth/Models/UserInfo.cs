using System.Collections.Generic;

namespace Crm.v1.Clients.Auth.Models
{
    public class UserInfo
    {
        public string Name { get; set; }

        public List<string> Roles { get; set; }
    }
}
