using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Account.Models;

namespace Crm.v1.Clients.Account.Clients
{
    public interface IAccountFlagsClient
    {
        Task<bool> IsSetAsync(
            AccountFlagType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task<List<AccountFlagType>> GetNotSetListAsync(
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);

        Task SetAsync(
            AccountFlagType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
