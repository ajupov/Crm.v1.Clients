using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Crm.v1.Clients.Clients.Auth.Clients
{
    public interface IAuthClient
    {
        public Task<bool> IsAuthenticatedAsync(Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
