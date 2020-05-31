namespace Crm.V1.Clients.OAuth.Models
{
    public class Tokens
    {
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public string TokenType { get; set; }

        public int ExpiresIn { get; set; }
    }
}
