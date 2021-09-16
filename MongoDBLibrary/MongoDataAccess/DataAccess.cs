using MongoDB.Driver;
using MongoDBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBLibrary.MongoDataAccess
{
    public static class DataAccess
    {
        private static IMongoDatabase _db;
        static DataAccess()
        {
            MongoClient client = new MongoClient();
            _db = client.GetDatabase("CustomerReservation");
        }

        public static void InsertCustomer<T>(string table, T record)
        {
            var collection = _db.GetCollection<T>(table);
            collection.InsertOne(record);
        }





    }
       
}
