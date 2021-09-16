using MongoDBLibrary.Models;
using MongoDBLibrary.MongoDataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBLibrary.Business_Logic
{

    public class CustomerProcessor
    {

        public static void CreateCustomer(string firstName,
            string LastName, string PhoneNumber, string Date)
        {

            CustomerModel data = new CustomerModel
            {
                FirstName = firstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Date = Date
            };
            DataAccess.InsertCustomer("Reservation",data);
        }

     



    }
}
