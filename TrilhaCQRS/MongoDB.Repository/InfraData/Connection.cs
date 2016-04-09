using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB.Repository.InfraData
{
    public class Connection
    {
        private static readonly string Database;
        static Connection()
        {
            Database = ConfigurationManager.AppSettings["database"];
        }

        public IMongoDatabase CrieConexao()
        {            
            var cliente = new MongoClient("mongodb://localhost");
            var mongoDataBase = cliente.GetDatabase(Database);
            return mongoDataBase;
        }
    }
}
