using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBLibrary.MongoDataAccess
{
    public class SupplierService
    {
        /// <summary>
        /// Initializing the database
        /// </summary>
        IMongoCollection<SupplierBrandName> BrandName;
        public SupplierService(IMongoClient client)
        {
            var databse = client.GetDatabase("OurSuppliers");
            BrandName = databse.GetCollection<SupplierBrandName>("BrandNames");
        }


        /// <summary>
        /// Getting all the Supplier Name
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SupplierBrandName> GetSupplierName()
        {
            return BrandName.Find(new BsonDocument().ToJson()).ToList();
        }


    }
}
