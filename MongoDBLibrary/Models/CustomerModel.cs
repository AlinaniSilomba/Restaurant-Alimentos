using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBLibrary.Models
{
    [BsonIgnoreExtraElements]
    public class CustomerModel
    {
        public string FirstName { get; set; }
        [BsonElement("Last Name")]
        public string LastName { get; set; }
        [BsonElement("Phone Number")]
        public string PhoneNumber { get; set; }
        [BsonElement("Day")]
        public string Date { get; set; } = DateTime.Now.ToString("dddd");
    }
}
