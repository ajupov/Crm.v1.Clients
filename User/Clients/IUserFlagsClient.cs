using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.User.Models;

namespace Crm.v1.Clients.User.Clients
{
    public interface IUserFlagsClient
    {
        Task<bool> IsSetAsync(UserFlagType type, Dictionary<string, string> headers, CancellationToken ct = default);

        Task<List<UserFlagType>> GetNotSetListAsync(Dictionary<string, string> headers, CancellationToken ct = default);

        Task SetAsync(UserFlagType type, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
