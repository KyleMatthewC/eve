using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Newtonsoft.Json;
using Microsoft.IdentityModel.Tokens;
using Eve.DataClass;

namespace Eve.JWT_Provider
{
    public class JWTServices
    {
        private readonly JWTSettings JWT;

        public JWTServices(JWTSettings jwtAccessor)
        {
            JWT = jwtAccessor;
        }
        public JwtSecurityToken GetToken(UserAccount user)
        {
            var now = DateTimeOffset.UtcNow;

            // Specifically add the jti (random nonce), iat (issued timestamp), and sub (subject/user) claims.
            // You can add other claims here, if you want:
            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.username),
                new Claim(JwtRegisteredClaimNames.Iat, now.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
            };

            // Create the JWT and write it to a string
            var token = new JwtSecurityToken(
                issuer: JWT.Issuer,
                audience: JWT.Audience,
                claims: claims,

                expires: JWT.Expiration,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWT.SecretKey)), SecurityAlgorithms.HmacSha256)
            );

            return token;
        }
    }
}
