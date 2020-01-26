namespace Crm.v1.Clients.OAuth.ResponseParameters
{
    public class TokenResponseParameter
    {
        public string access_token { get; set; }

        public string refresh_token { get; set; }

        public string token_type { get; set; }

        public int expires_in { get; set; }

        public string error { get; set; }
    }
}