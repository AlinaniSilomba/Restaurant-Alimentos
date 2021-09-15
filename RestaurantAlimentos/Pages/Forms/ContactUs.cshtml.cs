using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantAlimentos.Models;

namespace RestaurantAlimentos.Pages.Forms
{
    public class ContactUsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public CompanyModel company { get; set; }
        public void OnGet()
        {
            company.CompanyPhoneNumber = "0979162290";
            company.EmailAddress = "info@restaurantalimentos";
        }
    }
}
