﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Models;

namespace IdentityServer.Basico
{
    public class Clientes
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {           
                new Client
                {
                    ClientName = "Douglas Mendes",
                    ClientId = "IdentificacaoDoCliente",
                    Enabled = true,
                    AccessTokenType = AccessTokenType.Reference,
                    Flow = Flows.ClientCredentials,
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("F621F470-9731-4A25-80EF-67A6F7C5F4B8".Sha256())
                    },
                    AllowedScopes = new List<string>
                    {
                        "apiTest"
                    }
                }
            };
        }
    }
}
