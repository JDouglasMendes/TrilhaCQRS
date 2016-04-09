using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Repository.Contrato;
using MongoDB.Repository.Dominio;

namespace MongoDB.Repository.Repository
{
    public class ContatoRepository : Repository<Contato> , IContatoRepository
    {
        public ContatoRepository() : base("Contato")
        {
        }
    }
}
