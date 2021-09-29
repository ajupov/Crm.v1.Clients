using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Account.Requests;
using Crm.v1.Clients.Clients.Account.Responses;

namespace Crm.v1.Clients.Clients.Account.Clients
{
    public interface IAccountSettingChangesClient
    {
        public Task<AccountSettingChangeGetPagedListResponse> GetPagedListAsync(
            AccountSettingChangeGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);
    }
}
