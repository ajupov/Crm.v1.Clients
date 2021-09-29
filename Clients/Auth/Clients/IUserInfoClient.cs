using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Clients.Auth.Models;

namespace Crm.v1.Clients.Clients.Auth.Clients
{
    public interface IUserInfoClient
    {
        public Task<UserInfo> GetAsync(Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
