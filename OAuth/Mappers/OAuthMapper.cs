using Crm.v1.Clients.OAuth.Models;
using Crm.v1.Clients.OAuth.ResponseParameters;

namespace Crm.v1.Clients.OAuth.Mappers
{
    public static class OAuthMapper
    {
        public static Tokens Map(this TokenResponseParameter response)
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