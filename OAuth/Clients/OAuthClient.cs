using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Ajupov.Utils.All.String;
using Crm.v1.Clients.OAuth.Mappers;
using Crm.v1.Clients.OAuth.Models;
using Crm.v1.Clients.OAuth.Requests;
using Crm.v1.Clients.OAuth.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.OAuth.Clients
{
    public class OAuthClient : IOAuthClient
    {
        private readonly string _clientId;
        private const string PasswordGrandType = "password";
        private const string RefreshTokenGrandType = "refresh_token";

        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public OAuthClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _clientId = options.Value.ClientId;
            _url = UriBuilder.Combine(options.Value.OAuthHost, "OAuth");
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Tokens> GetTokensAsync(string username, string password, CancellationToken ct = default)
        {
            var request = new TokenRequest
            {
                grant_type = PasswordGrandType,
                client_id = _clientId,
                username = username,
                password = password
            };

            var response = await _httpClientFactory.PostFormDataAsync<TokenResponse>(
                UriBuilder.Combine(_url, "Token"), request, ct: ct);

            if (!response.error.IsEmpty())
            {
                throw new Exception(response.error);
            }

            return response.Map();
        }

        public async Task<Tokens> RefreshTokensAsync(string refreshToken, CancellationToken ct = default)
        {
            var request = new TokenRequest
            {
                grant_type = RefreshTokenGrandType,
                client_id = _clientId,
                refresh_token = refreshToken
            };

            var response = await _httpClientFactory.PostFormDataAsync<TokenResponse>(
                UriBuilder.Combine(_url, "Token"), request, ct: ct);

            if (!response.error.IsEmpty())
            {
                throw new Exception(response.error);
            }

            return response.Map();
        }
    }
}