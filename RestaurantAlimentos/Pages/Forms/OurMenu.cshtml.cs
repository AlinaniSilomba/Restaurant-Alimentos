using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MongoDBLibrary.Models;
using MongoDBLibrary.MongoDataAccess;

namespace RestaurantAlimentos.Pages.Forms
{
    public class OurMenuModel : PageModel
    {

        private readonly ILogger<OurMenuModel> _logger;
        public MenuItemService ProductService;

        public IEnumerable<MenuItems> Products { get; private set; }



        public OurMenuModel(ILogger<OurMenuModel> logger, MenuItemService menuItemService)
        {
            _logger = logger;
            ProductService = menuItemService;
        }

        public void OnGet()
        {
            Products = ProductService.GetMenuItems();
        }
    }
}
