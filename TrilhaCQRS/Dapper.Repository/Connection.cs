using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository
{
    public class Connection : IDisposable
    {
        private SqlConnection Conexao { get;  set; }
        public SqlConnection CrieConexao()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Dapper"].ConnectionString;
            Conexao = new SqlConnection(connectionString);
            Conexao.Open();
            return Conexao;
        }

        public void Dispose()
        {
            Conexao?.Dispose();
        }
    }
}
