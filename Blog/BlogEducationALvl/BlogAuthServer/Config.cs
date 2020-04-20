﻿using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAuthServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetAllApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("BlogApi", "Api for Blog")

            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> {
                new Client{
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {
                        new Secret("secret".Sha256())
                    },

                    AllowedScopes = {"BlogApi"}

                }
            };
        }
    }
}
