using System.Collections.Generic;

namespace Crm.v1.Clients.Account.Models
{
    public class AccountSettingChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<AccountSettingChange> Changes { get; set; }
    }
}
