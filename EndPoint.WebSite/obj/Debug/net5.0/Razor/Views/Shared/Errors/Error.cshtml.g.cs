#pragma checksum "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Shared\Errors\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6df398053cfe3b2525f8f472e95b8d64e891b43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Errors_Error), @"mvc.1.0.view", @"/Views/Shared/Errors/Error.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\_ViewImports.cshtml"
using EndPoint.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6df398053cfe3b2525f8f472e95b8d64e891b43", @"/Views/Shared/Errors/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d0c7bc3adcd10db8d0cbb09ec5ac66abbf68a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Errors_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Shared\Errors\Error.cshtml"
  
    ViewData["Title"] = "Page Not Found";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"clear\"></div>\n<div class=\"nk_container_404 product-content-onliner\">\n    <div class=\"c-404__title\">\n");
#nullable restore
#line 10 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Shared\Errors\Error.cshtml"
         if (Convert.ToBoolean(ViewBag.ErrorMessage404)==true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h1 style=""text-align: center;"">??????????????? ???? ?????????? ???? ?????????? ???????? ??????!</h1>
            <p>
                <img class=""aligncenter wp-image-2613 size-full""
                     src=""/Images/Settings/Error404.png""
                     alt=""404 Error""
                     srcset=""/Images/Settings/Error404.png 918w,/Images/Settings/Error404.png  600w"" sizes=""(max-width: 918px) 100vw, 918px"" width=""918"" height=""454"">
            </p>
");
#nullable restore
#line 19 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Shared\Errors\Error.cshtml"
        } else if (Convert.ToBoolean(ViewBag.ErrorMessage500)==true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h1 style=""text-align: center;"">?????????? ???? ?????????? ???? ???????? ?????????? ?????? ??????. ???????? ???????????? ?????? ???????? ????????!</h1>
            <p>
                <img class=""aligncenter wp-image-2613 size-full""
                     src=""/Images/Settings/Error500.png""
                     alt=""404 Error""
                     srcset=""/Images/Settings/Error404.png 918w,/Images/Settings/Error404.png  600w"" sizes=""(max-width: 918px) 100vw, 918px"" width=""918"" height=""454"">
            </p> 
");
#nullable restore
#line 28 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Shared\Errors\Error.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"c-404__actions\"></div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
