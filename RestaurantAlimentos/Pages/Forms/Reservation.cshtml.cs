using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantAlimentos.Models;
using MongoDBLibrary;
using MongoDBLibrary.Business_Logic;
using static MongoDBLibrary.Business_Logic.CustomerProcessor;

namespace RestaurantAlimentos.Pages.Forms
{
    public class ReservationModel : PageModel
    {
        [BindProperty]
        public CustomerModel customer { get; set; }

       

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                
                CreateCustomer(customer.FirstName,
                               customer.LastName,
                               customer.PhoneNumber,
                               customer.Date.ToString("d"));

                return RedirectToPage("/Forms/ReservationConfirmed");
            }
            return Page();
        }

       public void OnGet()
        {

        }

    }
}
