using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.OAuth.Responses;

namespace Crm.v1.Clients.OAuth.Clients
{
    public interface IOAuthClient
    {
        Task<TokenResponse> GetTokensAsync(
            string username,
            string password,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task<TokenResponse> RefreshTokensAsync(
            string refreshToken,
            Dictionary<string, string> headers,
            CancellationToken ct = default);
    }
}
