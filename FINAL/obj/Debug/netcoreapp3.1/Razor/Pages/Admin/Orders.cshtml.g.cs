#pragma checksum "C:\Users\jackh\source\repos\OuiOuiFashion-\FINAL\Pages\Admin\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5303bffffc28b1c7b1fe2f29250d7d68ceed5375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FINAL.Pages.Admin.Pages_Admin_Orders), @"mvc.1.0.razor-page", @"/Pages/Admin/Orders.cshtml")]
namespace FINAL.Pages.Admin
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
#line 1 "C:\Users\jackh\source\repos\OuiOuiFashion-\FINAL\Pages\_ViewImports.cshtml"
using FINAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jackh\source\repos\OuiOuiFashion-\FINAL\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5303bffffc28b1c7b1fe2f29250d7d68ceed5375", @"/Pages/Admin/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b8a6e577befa5385e55c43b5bae7bc36b65fa4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Orders : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


        <div class=""row"">
            <div class=""col-12"">
                <h6 class=""title"">Admin Panel</h6>
                <h1 class=""Admin-Header"">Orders</h1>
                <hr />
            </div>
            <div id=""search-area"" class=""row col-12"">
                <div class=""col-12 col-md-6 col-lg-4 col-xl-3""><input class=""form-control"" id=""search-rows"" type=""text"" placeholder=""Search..""></div>
                <div class=""col-12 col-md-6 col-lg-4 col-xl-3""><input class=""form-control d-none"" id=""refine-search"" type=""text"" placeholder=""refined..""></div>
            </div>
            <div class=""col-12 col-md-12"">
                <div id=""data-header"" class=""row"">
                    <div class=""col-4 col-md-2 col-xl-2"">
                        <b># Order ID</b>
                    </div>
                    <div class=""d-none d-md-block col-5 col-md-4 col-xl-3"">
                        Date
                    </div>
                    <div class=""d-none d-md-block col-5 col");
            WriteLiteral(@"-md-3 col-xl-3"">
                        Order Total
                    </div>
                    <div class=""d-none d-md-block col-5 col-md-3 col-xl-3"">
                        Status
                    </div>
                    <div class=""d-none d-md-block col-5 col-md-1 col-xl-1"">

                    </div>
                </div>
                <!-- ******************* change all areas which say 105 to the the order ID *************** -->

                ");
#nullable restore
#line 38 "C:\Users\jackh\source\repos\OuiOuiFashion-\FINAL\Pages\Admin\Orders.cshtml"
           Write(Html.Raw(Model.getOrders()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>



<div class=""modal fade"" id=""staticBackdrop"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Send Message</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <textarea></textarea>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-ouioui-primary"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-ouioui-primary"">Send</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FINAL.Pages.Admin.OrdersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FINAL.Pages.Admin.OrdersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FINAL.Pages.Admin.OrdersModel>)PageContext?.ViewData;
        public FINAL.Pages.Admin.OrdersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
