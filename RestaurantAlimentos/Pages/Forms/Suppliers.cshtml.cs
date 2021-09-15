using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantAlimentos.Models;

namespace RestaurantAlimentos.Pages.Forms
{
    public class SuppliersModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public SupplierModel supplier { get; set; }
        public void OnGet()
        {
            supplier.OurSuppliers = new List<string>()
            {
                "Trade Kings", "G&G", "Coca Cola", "Miranda", "Yalelo", "Buya Bamba", "Country Chicken"
            };
        }
    }
}
