using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QuanLyThuVien
{
    public static class Module
    {
        public static IMongoDatabase GetDatabase(string databaseName)
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient();

            return client.GetDatabase(databaseName);
        }
    }
}
