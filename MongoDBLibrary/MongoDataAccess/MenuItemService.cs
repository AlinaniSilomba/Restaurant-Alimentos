using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBLibrary.MongoDataAccess
{
    public class MenuItemService
    {
        /// <summary>
        /// Initializing the database
        /// </summary>
        IMongoCollection<MenuItems> MenuItems;
        public MenuItemService(IMongoClient client)
        {
            var databse = client.GetDatabase("RestaurantAlimentosMenu");
            MenuItems = databse.GetCollection<MenuItems>("Menu");
        }


        /// <summary>
        /// Getting all the products on the menu
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MenuItems> GetMenuItems()
        {
            return MenuItems.Find(new BsonDocument().ToJson()).ToList();
        }



    }
}
