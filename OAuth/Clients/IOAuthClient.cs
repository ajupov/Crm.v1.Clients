using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.OAuth.Models;

namespace Crm.v1.Clients.OAuth.Clients
{
    public interface IOAuthClient
    {
        Task<TokenResponse> GetTokensAsync(string username, string password, CancellationToken ct = default);

        Task<TokenResponse> RefreshTokensAsync(string refreshToken, CancellationToken ct = default);
    }
}
