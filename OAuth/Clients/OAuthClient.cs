using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Ajupov.Utils.All.String;
using Crm.v1.Clients.OAuth.Requests;
using Crm.v1.Clients.OAuth.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.OAuth.Clients
{
    public class OAuthClient : IOAuthClient
    {
        private readonly string _clientId;
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public OAuthClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _clientId = options.Value.ClientId;
            _url = UriBuilder.Combine(options.Value.OAuthHost, "OAuth");
            _httpClientFactory = httpClientFactory;
        }

        public async Task<TokenResponse> GetTokensAsync(
            string username,
            string password,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            var request = new TokenRequest
            {
                GrantType = "password",
                ClientId = _clientId,
                Username = username,
                Password = password
            };

            var response = await _httpClientFactory.PostFormDataAsync<TokenResponse>(
                UriBuilder.Combine(_url, "Token"), request, ct: ct);

            if (!response.Error.IsEmpty())
            {
                throw new Exception(response.Error);
            }

            return response;
        }

        public async Task<TokenResponse> RefreshTokensAsync(
            string refreshToken,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            var request = new TokenRequest
            {
                GrantType = "refresh_token",
                ClientId = _clientId,
                RefreshToken = refreshToken
            };

            var response = await _httpClientFactory.PostFormDataAsync<TokenResponse>(
                UriBuilder.Combine(_url, "Token"), request, ct: ct);

            if (!response.Error.IsEmpty())
            {
                throw new Exception(response.Error);
            }

            return response;
        }
    }
}
