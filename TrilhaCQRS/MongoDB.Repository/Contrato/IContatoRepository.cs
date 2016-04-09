using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Repository.Dominio;

namespace MongoDB.Repository.Contrato
{
    public interface IContatoRepository : IRepository<Contato>
    {
    }
}
