using System.Collections.Generic;
using Crm.v1.Clients.Account.Models;

namespace Crm.v1.Clients.Account.Responses
{
    public class AccountSettingChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<AccountSettingChange> Changes { get; set; }
    }
}
