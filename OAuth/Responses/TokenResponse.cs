namespace Crm.V1.Clients.OAuth.Responses
{
    public class TokenResponse
    {
        public string access_token { get; set; }

        public string refresh_token { get; set; }

        public string token_type { get; set; }

        public int expires_in { get; set; }

        public string error { get; set; }
    }
}
