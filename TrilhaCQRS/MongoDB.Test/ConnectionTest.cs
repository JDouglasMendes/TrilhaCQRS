using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Repository.InfraData;

namespace MongoDB.Test
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void TesteConexao()
        {
            var gerenciadorConexao = new Connection();
            var conexao = gerenciadorConexao.CrieConexao();
            Assert.IsNotNull(conexao, "Conexão está nula");
        }
    }
}
