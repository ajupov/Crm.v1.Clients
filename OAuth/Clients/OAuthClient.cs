using System;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.FormDataHttpClient;
using Ajupov.Utils.All.String;
using Crm.v1.Clients.OAuth.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.OAuth.Clients
{
    public class OAuthClient : IOAuthClient
    {
        private readonly string _host;
        private readonly string _clientId;
        private readonly IFormDataHttpClientFactory _factory;

        public OAuthClient(IOptions<OAuthClientsOptions> options, IFormDataHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _clientId = options.Value.ClientId;
            _factory = factory;
        }

        public async Task<TokenResponse> GetTokensAsync(
            string username,
            string password,
            CancellationToken ct = default)
        {
            var body = new TokenRequest
            {
                GrantType = "password",
                ClientId = _clientId,
                Username = username,
                Password = password
            };

            var response = await _factory.PostAsync<TokenResponse>(_host + "/OAuth/Token", null, body, null, ct);

            return !response.Error.IsEmpty() ? throw new Exception(response.Error) : response;
        }

        public async Task<TokenResponse> RefreshTokensAsync(string refreshToken, CancellationToken ct = default)
        {
            var body = new TokenRequest
            {
                GrantType = "refresh_token",
                ClientId = _clientId,
                RefreshToken = refreshToken
            };

            var response = await _factory.PostAsync<TokenResponse>(_host + "/OAuth/Token", null, body, null, ct);

            return !response.Error.IsEmpty() ? throw new Exception(response.Error) : response;
        }
    }
}
