using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Account.Models;

namespace Crm.v1.Clients.Account.Clients
{
    public interface IAccountSettingsClient
    {
        Task<AccountSetting> GetAsync(Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
