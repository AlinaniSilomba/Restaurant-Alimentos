using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MongoDBLibrary.Models;
using MongoDBLibrary.MongoDataAccess;
using RestaurantAlimentos.Models;

namespace RestaurantAlimentos.Pages.Forms
{
    public class SuppliersModel : PageModel
    {
        private readonly ILogger<SupplierModel> _logger;
        public SupplierService SupplierBrand;

        public IEnumerable<SupplierBrandName> BrandNames { get; private set;}

        public SuppliersModel(ILogger<SupplierModel> logger, SupplierService supplierService)
        {
            _logger = logger;
            SupplierBrand = supplierService;
        }

        public void OnGet()
        {

            BrandNames = SupplierBrand.GetSupplierName();
        }
    }
}
