using System.Collections.Generic;
using Crm.v1.Clients.User.Models;

namespace Crm.v1.Clients.User.Responses
{
    public class UserSettingChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<UserSettingChange> Changes { get; set; }
    }
}
