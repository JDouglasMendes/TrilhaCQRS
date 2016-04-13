using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Models;

namespace IdentityServer.Basico
{
    public static class Escopos
    {
        public static List<Scope> Get()
        {
            return new List<Scope>
            {
                    new Scope
                    {
                        Name = "apiTest"
                    }
            };
        }
    }
}
