namespace Crm.V1.Clients.OAuth.Requests
{
    public class TokenRequest
    {
        public string grant_type { get; set; }

        public string client_id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string refresh_token { get; set; }
    }
}
