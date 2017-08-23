using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Token.Server.Config
{
    internal class Clients
    {
        public static List<Client> GetClients()
        {
            return new List<Client>
            {

                new Client {
                    ClientId = "oauthClient",
                    ClientName = "Example Client Credentials Client Application",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret> {
                    new Secret("superSecretPassword".Sha256())},
                    AllowedScopes = new List<string> {"customAPI.read"}
                },

                new Client{
                    ClientId = "Eve.Web",
                    ClientName = "Eve.Web",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    ClientSecrets = {new Secret("eve-secret-key-08102017".Sha256()) },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "role",
                        "Eve.Web.write",
                        "Eve.Web.read"
                    },
                    RedirectUris = new List<string>{ "http://localhost:64458/signin-oidc" },
                    PostLogoutRedirectUris = new List<string>{ "http://localhost:64458" }
                }
            };
        }
    }
}
