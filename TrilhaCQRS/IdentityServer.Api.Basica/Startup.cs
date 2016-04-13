using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Owin;

namespace IdentityServer.Api.Basica
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {           
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "http://localhost:5000",
                ValidationMode = ValidationMode.ValidationEndpoint,

                RequiredScopes = new[] { "apiTest" } //Mesmo nome configurado no servidor.
            });         
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();         
            config.Filters.Add(new AuthorizeAttribute());
            app.UseWebApi(config);
        }
    }
}
