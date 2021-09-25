using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBLibrary.Models
{
    [BsonIgnoreExtraElements]
    public class MenuItems
    {

        public string Title { get; set; }
        public string Meal { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        [BsonElement("Img")]
        public string Image { get; set; }
    }
}
