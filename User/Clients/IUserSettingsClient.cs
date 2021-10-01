using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.User.Models;

namespace Crm.v1.Clients.User.Clients
{
    public interface IUserSettingsClient
    {
        Task<UserSetting> GetAsync(Dictionary<string, string> headers = default, CancellationToken ct = default);
    }
}
