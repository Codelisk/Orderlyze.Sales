﻿namespace WixApi.Models
{
    public class AuthRefreshPayload
    {
        public string grant_type { get; set; }
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string refresh_token { get; set; }
    }
}
