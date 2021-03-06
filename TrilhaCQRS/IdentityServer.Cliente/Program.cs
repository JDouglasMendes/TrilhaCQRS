﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IdentityModel.Client;

namespace IdentityServer.Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            CallApi(GetClienteToken());
        }
        static TokenResponse GetClienteToken()
        {
            var client = new TokenClient(
                "http://localhost:5000/connect/token",
                "IdentificacaoDoCliente",
                "F621F470-9731-4A25-80EF-67A6F7C5F4B8");

            return client.RequestClientCredentialsAsync("apiTest").Result;
        }
        static void CallApi(TokenResponse response)
        {
            var client = new HttpClient();
            client.SetBearerToken(response.AccessToken);

            Console.WriteLine(client.GetStringAsync("http://localhost:53710/teste").Result);
        }
    }
}
