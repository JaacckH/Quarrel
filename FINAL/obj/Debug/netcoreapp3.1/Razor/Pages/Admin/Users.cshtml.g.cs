#pragma checksum "C:\Users\jackh\source\repos\OuiOuiFashion-\FINAL\Pages\Admin\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ef542c027e59707a366cf79ea5d52de2ca3361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FINAL.Pages.Admin.Pages_Admin_Users), @"mvc.1.0.razor-page", @"/Pages/Admin/Users.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ef542c027e59707a366cf79ea5d52de2ca3361", @"/Pages/Admin/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b8a6e577befa5385e55c43b5bae7bc36b65fa4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Users : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""#admin-user-page"" class=""row"">
    <div class=""col-12"">
        <h6 class=""title"">Admin Panel</h6>
        <h1 class=""Admin-Header"">Users</h1>
        <hr />
    </div>

    <div id=""search-area"" class=""row col-12"">
        <div class=""col-12 col-md-6 col-lg-4 col-xl-3""><input class=""form-control"" id=""search-rows"" type=""text"" placeholder=""Search..""></div>
        <div class=""col-12 col-md-6 col-lg-4 col-xl-3""><input class=""form-control d-none"" id=""refine-search"" type=""text"" placeholder=""refined..""></div>
    </div>
</div>

<div class=""col-12 col-md-12"">
    <div id=""data-header"" class=""row"">
        <div class=""col-4 col-md-3 col-xl-3"">
            <b># User ID</b>
        </div>
        <div class=""d-none d-xl-block col-5 col-md-3 col-xl-2"">
            Name
        </div>
        <div class=""d-none d-xl-block col-5 col-md-2 col-xl-3"">
            Type
        </div>
        <div class=""d-none d-xl-block col-5 col-md-2 col-xl-2"">
            Orders
        </div>
       ");
            WriteLiteral(" <div class=\"d-none d-xl-block col-5 col-md-2 col-xl-2\">\r\n            Messages\r\n        </div>\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 38 "C:\Users\jackh\source\repos\OuiOuiFashion-\FINAL\Pages\Admin\Users.cshtml"
Write(Html.Raw(Classes.Users.getUsersHTML()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FINAL.Pages.Admin.UsersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FINAL.Pages.Admin.UsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FINAL.Pages.Admin.UsersModel>)PageContext?.ViewData;
        public FINAL.Pages.Admin.UsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591