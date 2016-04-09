using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Dapper.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dapper.Test
{
    [TestClass]
    public class ConnectionTest
    {    
        [TestMethod]
        public void TestConnection()
        {
            var gerenciador = new Connection();
            var conexao = gerenciador.CrieConexao();

            Assert.IsNotNull(conexao);
            Assert.IsTrue(conexao.State == ConnectionState.Open);
        }
    }
}
