using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Eve.JWT_Provider
{
    public class JWTSettings
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public DateTime Expiration { get; set; } = DateTime.UtcNow.AddMinutes(10);
        public SigningCredentials SigningCredentials { get; set; }
    }
}
