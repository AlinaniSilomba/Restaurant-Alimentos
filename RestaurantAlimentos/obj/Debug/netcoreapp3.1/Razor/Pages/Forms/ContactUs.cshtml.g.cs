#pragma checksum "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\Forms\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d8a2ed527a08585ce9e90c2be71eb1544b6198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantAlimentos.Pages.Forms.Pages_Forms_ContactUs), @"mvc.1.0.razor-page", @"/Pages/Forms/ContactUs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d8a2ed527a08585ce9e90c2be71eb1544b6198", @"/Pages/Forms/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6fb41273218066989abdbfd74ab194c5fca7e3f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Forms_ContactUs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\Forms\ContactUs.cshtml"
        ViewData["Title"] = "Restaurant Alimentos - ContactUs";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Contact Us</h1>\r\n<hr />\r\n<p>Please feel free to reach out us on <PhoneNumber>");
#nullable restore
#line 7 "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\Forms\ContactUs.cshtml"
                                               Write(Model.company.CompanyPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </PhoneNumber> or email us on <Mailto><a> ");
#nullable restore
#line 7 "C:\Users\Alinani\Documents\Temp\RestaurantAlimentos\RestaurantAlimentos\Pages\Forms\ContactUs.cshtml"
                                                                                                                           Write(Model.company.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </Mailto></p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantAlimentos.Pages.Forms.ContactUsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantAlimentos.Pages.Forms.ContactUsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantAlimentos.Pages.Forms.ContactUsModel>)PageContext?.ViewData;
        public RestaurantAlimentos.Pages.Forms.ContactUsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
