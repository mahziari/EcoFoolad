#pragma checksum "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f544f5f4fb0af860f374a18b8ae2372987f0503b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Category), @"mvc.1.0.view", @"/Views/Blogs/Category.cshtml")]
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
#line 1 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\_ViewImports.cshtml"
using EndPoint.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
using Application.Services.FrontEnd.Blogs.Queries;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f544f5f4fb0af860f374a18b8ae2372987f0503b", @"/Views/Blogs/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d0c7bc3adcd10db8d0cbb09ec5ac66abbf68a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultGetBlogsCategoryFrontEndDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blogs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cat_of_post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("bookmark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Pagination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
  
    ViewData["Title"] = "بلاگ اکوفولاد";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("BodyAttr", async() => {
                WriteLiteral("\n    data-rsssl=\"1\" class=\"rtl home page-template page-template-home-page page-template-home-page-php page page-id-1211 theme-newkala woocommerce-js nk_desktop nk_my_account_page loggedout elementor-default dokan-theme-newkala\"\n");
            }
            );
            WriteLiteral(@"


<div class=""container"">
    <div class=""module-title"">
        <div class=""module-title__txt"">
            <span class=""bold""></span>
            <span>
                <strong>آخرین مطالب </strong>
            </span>
        </div>

        <div class=""module-title__sep""></div>
    </div>

    <section class=""content_right_blog"" style=""width: 100%;"">
        <div class=""posts_blog"">

");
#nullable restore
#line 29 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
             foreach (var item in Model.BlogsCatrgory)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <article id=""post-1"" class=""post-1 post type-post status-publish format-standard has-post-thumbnail hentry category-148 category-147 category-uncategorized category-152 category-151 category-150 category-149"">
                    <div class=""main-wp-post-image"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f544f5f4fb0af860f374a18b8ae2372987f0503b6476", async() => {
                WriteLiteral("\n                            ");
#nullable restore
#line 38 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                       Write(item.NewsGroupName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
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
#line 35 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                                   WriteLiteral(item.en_NewsGroupName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                                WriteLiteral(item.Title.Replace(" ", "-"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
AddHtmlAttributeValue("", 1503, item.Title, 1503, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f544f5f4fb0af860f374a18b8ae2372987f0503b10475", async() => {
                WriteLiteral("\n                            <img width=\"300\" height=\"191\"");
                BeginWriteAttribute("src", "\n                                 src=\"", 1918, "\"", 1972, 2);
                WriteAttributeValue("", 1957, "/", 1957, 1, true);
#nullable restore
#line 47 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
WriteAttributeValue("", 1958, item.HeadLine, 1958, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\n                                 data-lazy-srcset=\"/");
#nullable restore
#line 48 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                                               Write(item.HeadLine);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-lazy-sizes=\"(max-width: 300px) 100vw, 300px\"\n                                 data-lazy-src=\"/");
#nullable restore
#line 49 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                                            Write(item.HeadLine);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\n                                 class=\"attachment-medium size-medium wp-post-image\"");
                BeginWriteAttribute("alt", " alt=\"", 2241, "\"", 2258, 1);
#nullable restore
#line 50 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
WriteAttributeValue("", 2247, item.Title, 2247, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            <noscript>\n                                <img width=\"300\" height=\"191\"");
                BeginWriteAttribute("src", " src=\"", 2361, "\"", 2382, 2);
                WriteAttributeValue("", 2367, "/", 2367, 1, true);
#nullable restore
#line 52 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
WriteAttributeValue("", 2368, item.HeadLine, 2368, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"attachment-medium size-medium wp-post-image\"");
                BeginWriteAttribute("alt", " alt=\"", 2435, "\"", 2452, 1);
#nullable restore
#line 52 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
WriteAttributeValue("", 2441, item.Title, 2441, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("srcset", "\n                                     srcset=\"", 2453, "\"", 2514, 2);
                WriteAttributeValue("", 2499, "/", 2499, 1, true);
#nullable restore
#line 53 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
WriteAttributeValue("", 2500, item.HeadLine, 2500, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" sizes=\"(max-width: 300px) 100vw, 300px\"/>\n                            </noscript>\n                        ");
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
#line 44 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                                   WriteLiteral(item.en_NewsGroupName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                                WriteLiteral(item.Title.Replace(" ", "-"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("                    </div>\n\n                    <h3 class=\"entry-title\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f544f5f4fb0af860f374a18b8ae2372987f0503b16996", async() => {
                WriteLiteral("\n                            ");
#nullable restore
#line 67 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        ");
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
#line 64 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                                   WriteLiteral(item.en_NewsGroupName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                                WriteLiteral(item.Title.Replace(" ", "-"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </h3>\n                    <div class=\"entry-summary\">\n                        <p>");
#nullable restore
#line 71 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                      Write(item.NewsSummery);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div><!-- .entry-summary -->\n\n                    <div class=\"author\">\n\n                        <img");
            BeginWriteAttribute("alt", " alt=\"", 3478, "\"", 3495, 1);
#nullable restore
#line 76 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
WriteAttributeValue("", 3484, item.Title, 3484, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" src=""/Images/Favicon/favicon-16x16.png"" data-lazy-srcset=""/Images/Favicon/favicon-16x16.png"" class=""avatar avatar-30 photo"" height=""30"" width=""30""
                             data-lazy-src=""/Images/Favicon/favicon-16x16.png"">
                        <noscript>
                            <img");
            BeginWriteAttribute("alt", " alt=\'", 3791, "\'", 3808, 1);
#nullable restore
#line 79 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
WriteAttributeValue("", 3797, item.Title, 3797, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" src=\'/Images/Favicon/favicon-16x16.png\' srcset=\'/Images/Favicon/favicon-16x16.png\' class=\'avatar avatar-30 photo\' height=\'30\' width=\'30\'/>\n                        </noscript>\n");
            WriteLiteral("                    </div>\n\n\n                    <div class=\"human_time_diff\">");
#nullable restore
#line 85 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
                                            Write(item.RegisterDatePersian);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n                </article>\n                <!-- #post-## -->\n");
#nullable restore
#line 89 "C:\Users\pc-2\Pictures\.NET\01_MyProject\EndPoint.WebSite\Views\Blogs\Category.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            <div class=\"archive_pagination\" lang=\"fa\">\n            </div>\n\n        </div>\n    </section>\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f544f5f4fb0af860f374a18b8ae2372987f0503b23003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n");
            WriteLiteral("    <div class=\"clear\"></div>\n</div>\n<div class=\"clear\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultGetBlogsCategoryFrontEndDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
