﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WixApi.Models
{
    public class AuthResponse
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
    }
}
