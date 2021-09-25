using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBLibrary.Models
{
    [BsonIgnoreExtraElements]
     public class SupplierBrandName
    {
        /// <summary>
        /// This is our Model for our suppliers.
        /// </summar>
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Name")]
        public string SupplierName { get; set; }
    }
}
