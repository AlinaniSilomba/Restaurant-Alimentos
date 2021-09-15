using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantAlimentos.Models;

namespace RestaurantAlimentos.Pages.Forms
{
    public class ReservationModel : PageModel
    {
        [BindProperty]
        public CustomerModel customer { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return NotFound("Something bad happened please try again");
            }

            return RedirectToPage("/Forms/ReservationConfirmed");
        }

       public void OnGet()
        {

        }

    }
}
