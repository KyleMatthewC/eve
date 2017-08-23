using IdentityModel;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Token.Server.Config
{
    internal class Users
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser> {
            new TestUser {
                SubjectId = "1",
                Username = "kylechua@navitaire.com",
                Password = "123456",
                Claims = new List<Claim> {
                    new Claim(JwtClaimTypes.Email, "kylechua@navitaire.com"),
                    new Claim(JwtClaimTypes.Role, "admin")
                }
            }
        };
        }
    }
}
