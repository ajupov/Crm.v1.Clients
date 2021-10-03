using System.Collections.Generic;

namespace Crm.v1.Clients.User.Models
{
    public class UserSettingChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<UserSettingChange> Changes { get; set; }
    }
}
