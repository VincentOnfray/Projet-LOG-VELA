
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_utilisateur_vela
{
    class MongoApiConnector
    {
        private static MongoApiConnector Instance;

        public MongoClient mClient;

        public static MongoApiConnector getInstance()
        {
            if (Instance == null)
            {
                Instance = new MongoApiConnector();
            }

            return Instance;
        }



        public MongoApiConnector()
        {

            mClient = new MongoClient("mongodb://localhost:27017/Vela");
        }

        public void Log(string content)
        {
            var json = new Log(content).AsDoc();
            var database = mClient.GetDatabase("Vela");
            var collection = database.GetCollection<BsonDocument>("Vela_Logs");
            collection.InsertOne(json);
        }


    }

    public class Log{

        public Log(string content)
        {
            Date = DateTime.Now.ToString();
            Content = content;
        }

        public string Date;

        public String Content;

        public string AsJson()
        {
            var json = JsonConvert.SerializeObject(this);
            return json;
        }

        public BsonDocument AsDoc()
        {
            var document = new BsonDocument
            {
                { "Date", Date },
                { "Content", Content }
            };

            return document;
        }

    }

}
