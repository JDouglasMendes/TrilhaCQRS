using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Configuration;
using IdentityServer3.Core.Resources;
using IdentityServer3.Core.Services.InMemory;
using Owin;

namespace IdentityServer.Basico
{
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = new IdentityServerOptions
            {
                Factory = new IdentityServerServiceFactory()
                            .UseInMemoryClients(Clientes.Get())
                            .UseInMemoryScopes(Escopos.Get())
                            .UseInMemoryUsers(new List<InMemoryUser>()),

                RequireSsl = false
            };

            app.UseIdentityServer(options);
        }
    }
}
