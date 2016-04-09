using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Repository.Dominio;
using MongoDB.Repository.Repository;

namespace MongoDB.Test
{
    [TestClass]
    public class RepositoryContatoTest
    {
        [TestMethod]
        public void TesteInsertContato()
        {
            var repositorio = new ContatoRepository();
            repositorio.Insert(CrieContato());
        }

        [TestMethod]
        public void TesteUpdateContato()
        {
            var repositorio = new ContatoRepository();
            var contato = CrieContato();
            contato.Telefone = "62 81XXXXXXXX";
            repositorio.Update(contato);
        }

        [TestMethod]
        public void TesteFindContato()
        {
            var repositorio = new ContatoRepository();
            var contato = repositorio.Find(1);
            Assert.IsNotNull(contato);
            Assert.AreEqual(1, contato.Id);
        }

        [TestMethod]
        public void TesteFindAllContato()
        {
            var repositorio = new ContatoRepository();
            var contato = repositorio.FindAll();
            Assert.IsNotNull(contato);
            Assert.IsTrue(contato.Any());
        }

        [TestMethod]
        public void TesteDeleteContato()
        {
            var repositorio = new ContatoRepository();
            repositorio.Delete(new Contato() {Id = 1});            
        }

        private static Contato CrieContato()
        {
            return new Contato()
            {
                Id = 1,
                Nome = "Douglas Mendes",
                Telefone = "62 8102XXXXX"
            };
        }
    }
}
