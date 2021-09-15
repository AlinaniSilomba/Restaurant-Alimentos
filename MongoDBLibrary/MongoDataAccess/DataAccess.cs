using MongoDB.Driver;
using MongoDBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBLibrary.MongoDataAccess
{
    public class DataAccess
    {
        public IMongoCollection<CustomerModelDB> _CustomerModelDB;
        public DataAccess(IMongoClient client)
        {
            var database = client.GetDatabase("CustomerDB");
            _CustomerModelDB = database.GetCollection<CustomerModelDB>("Reservation");

        }

        public Task InserCustomer (IEnumerable<CustomerModelDB> customers)
        {
            return _CustomerModelDB.InsertManyAsync(customers);
        }

    }
}
