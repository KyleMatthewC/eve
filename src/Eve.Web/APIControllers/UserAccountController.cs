using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Eve.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Collections;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Newtonsoft.Json;
using Eve.JWT_Provider;
using Eve.Models;

namespace Eve.Web.Controllers
{
    [Route("api/[controller]")]
    public class UserAccountController : Controller
    {

        private readonly JWTSettings _options;

        public UserAccountController(IOptions<JWTSettings> jwtAccessor)
        {
            _options = jwtAccessor.Value;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel userCredentials)
        {
            var JWTGenerator = new JWTServices(_options);
            if (ModelState.IsValid)
            {
                var user = new UserAccountModel().GetUser(userCredentials.username, userCredentials.password);

                if(user != null)
                {
                    var token = JWTGenerator.GetToken(user);
                    var jwtoken = new JwtSecurityTokenHandler().WriteToken(token);

                    var returnToken = new JWTToken();
                    returnToken.token = jwtoken;
                    returnToken.expiration = token.ValidTo;

                    WriteCookie("AccessToken", jwtoken, token.ValidTo);

                    return Ok(returnToken);
                }
                
                return new JsonResult("Unable to sign in") { StatusCode = 401 };
            }
            var errors = ModelState.SelectMany(x => x.Value.Errors.Select(z => z.Exception));

            return new JsonResult("Unexpected error");
        }

        public void WriteCookie(string key, string token, DateTime expires)
        {
            CookieOptions option = new CookieOptions();
            option.Secure = true;
            option.HttpOnly = true;
            option.Expires = expires;
            Response.Cookies.Append(key, "Bearer " + token, option);
        }
    }
}
