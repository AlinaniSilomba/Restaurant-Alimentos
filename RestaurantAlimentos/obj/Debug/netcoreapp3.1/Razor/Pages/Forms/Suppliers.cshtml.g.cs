#pragma checksum "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\Forms\Suppliers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c9f3d9915da420649fe5da603d9826d2bca4405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantAlimentos.Pages.Forms.Pages_Forms_Suppliers), @"mvc.1.0.razor-page", @"/Pages/Forms/Suppliers.cshtml")]
namespace RestaurantAlimentos.Pages.Forms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\_ViewImports.cshtml"
using RestaurantAlimentos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9f3d9915da420649fe5da603d9826d2bca4405", @"/Pages/Forms/Suppliers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6fb41273218066989abdbfd74ab194c5fca7e3f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forms_Suppliers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\Forms\Suppliers.cshtml"
  
    ViewData["Title"] = "Restaurant Alimentos - Suppliers Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Our Suppliers</h1>\r\n\r\n\r\n<section class=\"Supplier-list\">\r\n    <table class=\"table table-striped\">\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\Forms\Suppliers.cshtml"
             foreach (var supplier in Model.BrandNames)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 16 "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\Forms\Suppliers.cshtml"
                   Write(supplier.SupplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 18 "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\Forms\Suppliers.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantAlimentos.Pages.Forms.SuppliersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantAlimentos.Pages.Forms.SuppliersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantAlimentos.Pages.Forms.SuppliersModel>)PageContext?.ViewData;
        public RestaurantAlimentos.Pages.Forms.SuppliersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
