using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.JWT_Provider
{
    public class JWTToken
    {
        public string token { get; set; }

        public DateTime expiration { get; set; }
    }
}
