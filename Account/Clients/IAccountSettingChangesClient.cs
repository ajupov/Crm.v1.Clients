using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Account.Models;

namespace Crm.v1.Clients.Account.Clients
{
    public interface IAccountSettingChangesClient
    {
        public Task<AccountSettingChangeGetPagedListResponse> GetPagedListAsync(
            AccountSettingChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
