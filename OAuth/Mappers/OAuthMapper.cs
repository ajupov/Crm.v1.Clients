using Crm.V1.Clients.OAuth.Models;
using Crm.V1.Clients.OAuth.Responses;

namespace Crm.V1.Clients.OAuth.Mappers
{
    public static class OAuthMapper
    {
        public static Tokens Map(this TokenResponse response)
        {
            return new Tokens
            {
                AccessToken = response.access_token,
                RefreshToken = response.refresh_token,
                TokenType = response.token_type,
                ExpiresIn = response.expires_in
            };
        }
    }
}
