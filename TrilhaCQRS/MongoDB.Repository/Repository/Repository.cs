using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Repository.Contrato;
using MongoDB.Repository.Dominio;
using MongoDB.Repository.InfraData;

namespace MongoDB.Repository.Repository
{
    public abstract class Repository<TEntidade> : IRepository<TEntidade> where TEntidade : ColecaoPersistente 
    {
        protected IMongoDatabase Database { get; set; }
        protected string Colecao { get; private set; }

        protected Repository(string colecao)
        {
            Colecao = colecao;
            Database = new Connection().CrieConexao();
        }

        public void Insert(TEntidade entidade)
        {            
            var collection = Database.GetCollection<BsonDocument>(Colecao);
            collection.InsertOne(entidade.ToBsonDocument());
        }

        public void Update(TEntidade entidade)
        {
            var collection = Database.GetCollection<BsonDocument>(Colecao);
            var documento = entidade.ToBsonDocument();
            var resultado = collection.ReplaceOne(filter: new BsonDocument("_id", entidade.Id), replacement: documento);          
        }

        public TEntidade Find(int id)
        {
            var collection = Database.GetCollection<TEntidade>(Colecao);
            var filter = Builders<TEntidade>.Filter.Eq("_id", id);
            var retorno = collection.Find(filter).ToList().FirstOrDefault();
            return retorno;
        }

        public IEnumerable<TEntidade> FindAll()
        {
            var collection = Database.GetCollection<TEntidade>(Colecao);
            var filter = new BsonDocument();
            return collection.Find(filter).ToList();
        }

        public void Delete(TEntidade tEntidade)
        {
            var collection = Database.GetCollection<TEntidade>(Colecao);
            var filter = Builders<TEntidade>.Filter.Eq("_id", tEntidade.Id);
            collection.DeleteOne(filter);
        }
    }
}
