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
        /// <summary>
        /// This is our database initialization method.
        /// </summary>
        private static IMongoDatabase _db;
        static DataAccess()
        {
            MongoClient client = new MongoClient();
            _db = client.GetDatabase("CustomerReservation");
        }
        /// <summary>
        /// /This is how we are inserting customers in Mongo database 
        /// </summary>
        /// <typeparam name="T"> This is a generic List</typeparam>
        /// <param name="table"> this table is the database name</param>
        /// <param name="record"> this record is the document itself</param>
        public static void InsertCustomer<T>(string table, T record)
        {
            var collection = _db.GetCollection<T>(table);
            collection.InsertOne(record);
        }





    }
       
}
