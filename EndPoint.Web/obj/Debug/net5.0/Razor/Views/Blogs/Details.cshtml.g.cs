#pragma checksum "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/Blogs/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71de21cce90d2e3acdead40b3f3957ebbfc3f76d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Details), @"mvc.1.0.view", @"/Views/Blogs/Details.cshtml")]
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
#line 1 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/_ViewImports.cshtml"
using EndPoint.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/_ViewImports.cshtml"
using EndPoint.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/Blogs/Details.cshtml"
using ParsaPoolad.Application.Services.FrontEnd.Blogs.Queries;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71de21cce90d2e3acdead40b3f3957ebbfc3f76d", @"/Views/Blogs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9edee2fb53f02e42044aaea54804593705240da2", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultGetBlogsDetailsFrontEndDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blogs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/Blogs/Details.cshtml"
  
    ViewData["Title"] = "بلاگ اکوفولاد";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"" style=""margin-top:20px;"">


    <section class=""content_right_blog"">

        <div class=""main_content_post_blog"">

            <ul class=""woocommerce-breadcrumb"">
                <li>
                    <a href=""/"">اکوفولاد</a>
                </li>
                <span>/</span>
                <li>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71de21cce90d2e3acdead40b3f3957ebbfc3f76d4544", async() => {
                WriteLiteral("\n                        ");
#nullable restore
#line 26 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/Blogs/Details.cshtml"
                   Write(Model.Blog.NewsGroupName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/Blogs/Details.cshtml"
                               WriteLiteral(Model.Blog.en_NewsGroupName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </li>\n                <span>/</span>\n                <li>");
#nullable restore
#line 30 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/Blogs/Details.cshtml"
               Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            </ul>\n\n            <h1 class=\"title_single_post\">");
#nullable restore
#line 33 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/Blogs/Details.cshtml"
                                     Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n            <div class=\"main_post_meta\">\n                \n                <div class=\"author\">\n                    <img");
            BeginWriteAttribute("alt", " alt=\"", 1117, "\"", 1123, 0);
            EndWriteAttribute();
            WriteLiteral(@" src=""https://newkalatheme.ir/preview/wp-content/uploads/2020/05/cropped-NKaka-New-logo-1.png"" class=""avatar avatar-30 photo lazyloaded"" height=""30"" width=""30"" srcset=""https://newkalatheme.ir/preview/wp-content/uploads/2020/05/cropped-NKaka-New-logo-1.png 2x"" data-ll-status=""loaded""><noscript><img");
            BeginWriteAttribute("alt", " alt=\'", 1422, "\'", 1428, 0);
            EndWriteAttribute();
            WriteLiteral(@" src='https://newkalatheme.ir/preview/wp-content/uploads/2020/05/cropped-NKaka-New-logo-1.png' srcset='https://newkalatheme.ir/preview/wp-content/uploads/2020/05/cropped-NKaka-New-logo-1.png 2x' class='avatar avatar-30 photo' height='30' width='30' /></noscript>
                	<a href=""https://newkalatheme.ir/preview/author/newkala/"">سردبیر خبری</a>
                </div>
                

                <div class=""date_publish"" lang=""fa"">");
#nullable restore
#line 43 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/Blogs/Details.cshtml"
                                               Write(Model.Blog.RegisterDatePersian);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n            </div>\n\n");
            WriteLiteral("            \n");
            WriteLiteral("            <div class=\"product-content-onliner\">\n                ");
#nullable restore
#line 57 "/Users/hosseinkaraji/NET5/02_Developing/01_ParsaPoolad/EndPoint.Web/Views/Blogs/Details.cshtml"
           Write(Html.Raw(Model.Blog.NewsBody));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n\n            <div class=\"comments-wrapper\"></div>\n\n        </div>\n\n    </section>\n\n");
            WriteLiteral("    <div class=\"clear\"></div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultGetBlogsDetailsFrontEndDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
