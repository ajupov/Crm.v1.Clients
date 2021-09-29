using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.User.Models;

namespace Crm.v1.Clients.Clients.User.Clients
{
    public interface IUserSettingsClient
    {
        Task<UserSetting> GetAsync(Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
