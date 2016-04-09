using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB.Repository.Contrato
{
    public interface IRepository<TEntidade>
    {
        void Insert(TEntidade entidade);
        void Update(TEntidade entidade);
        TEntidade Find(int entidade);
        IEnumerable<TEntidade> FindAll();
        void Delete(TEntidade tEntidade);
    }
}
