#pragma checksum "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9a8b50da89c35b9af37e9d3bdfbac5040cf84d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
using Application.Services.FrontEnd.Basket;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a8b50da89c35b9af37e9d3bdfbac5040cf84d1", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d0c7bc3adcd10db8d0cbb09ec5ac66abbf68a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove-from-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/Menus/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "سبد خرید";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
 if (Model.Items.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!--  cart------------------>
    <div class=""col-12"">
        <div class=""page-content"">
            <div class=""col-lg-4 col-md-4 col-xs-12 pull-right"">
                <div class=""checkout-tab"">
                    <div class=""checkout-tab-pill listing-active-cart"">
                        سبد خرید
                        <span class=""checkout-tab-counter"">");
#nullable restore
#line 18 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                                                      Write(Model.Items.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n");
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"cart-tab-main\">\r\n\r\n            <div class=\"col-lg-9 col-md-9 col-xs-12 pull-right\">\r\n");
#nullable restore
#line 28 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                 foreach (var item in Model.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"page-content-cart\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a8b50da89c35b9af37e9d3bdfbac5040cf84d17917", async() => {
                WriteLiteral("\r\n                            <div class=\"header-express\">\r\n");
                WriteLiteral("                            </div>\r\n\r\n                            <div class=\"checkout-body\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a8b50da89c35b9af37e9d3bdfbac5040cf84d18407", async() => {
                    WriteLiteral("\r\n                                    <i class=\"fa fa-close\"></i>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1626, "~/basket/RemoveItemFromBasket/", 1626, 30, true);
#nullable restore
#line 40 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
AddHtmlAttributeValue("", 1656, item.Id, 1656, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a8b50da89c35b9af37e9d3bdfbac5040cf84d110243", async() => {
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9a8b50da89c35b9af37e9d3bdfbac5040cf84d110543", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 48 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
AddHtmlAttributeValue("", 2232, item.ProductName, 2232, 17, false);

#line default
#line hidden
#nullable disable
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MenuName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                                           WriteLiteral(item.subMenuEnSgname.Replace(" ", "-"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MenuName"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MenuName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MenuName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                                          WriteLiteral(item.ProductName.Replace(" ", "-"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PrdName"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PrdName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PrdName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                <div class=\"checkout-col-desc\">\r\n                                    <a href=\"#\">\r\n                                        <h3>\r\n                                            ");
#nullable restore
#line 54 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </h3>\r\n                                    </a>\r\n                                    <div class=\"checkout-variant-color\">\r\n");
                WriteLiteral("                                        <div class=\"checkout-guarantee\">\r\n                                            <i class=\"fa fa-check\"></i>\r\n                                            ");
#nullable restore
#line 62 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                                       Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n");
                WriteLiteral("                                    </div>\r\n\r\n                                    <div class=\"quantity\">\r\n");
                WriteLiteral("                                        <input type=\"number\"");
                BeginWriteAttribute("onchange", "\r\n                                               onchange=\"", 3508, "\"", 3590, 3);
                WriteAttributeValue("", 3567, "SetQuantity(\'", 3567, 13, true);
#nullable restore
#line 70 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
WriteAttributeValue("", 3580, item.Id, 3580, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3588, "\')", 3588, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", "\r\n                                               id=\"", 3591, "\"", 3661, 2);
                WriteAttributeValue("", 3644, "quantity-", 3644, 9, true);
#nullable restore
#line 71 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
WriteAttributeValue("", 3653, item.Id, 3653, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                               value=\"", 3662, "\"", 3732, 1);
#nullable restore
#line 72 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
WriteAttributeValue("", 3718, item.Quantity, 3718, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                               step=\"1\"\r\n                                               min=\"1\"");
                BeginWriteAttribute("max", "\r\n                                               max=\"", 3846, "\"", 3900, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </div>\r\n\r\n\r\n                                    <a href=\"#\" class=\"add-to-sfl\">\r\n");
                WriteLiteral("                                        <div class=\"cart-item-product-price\">\r\n\r\n");
#nullable restore
#line 83 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                                              
                                                var price = (item.UnitPrice * item.Quantity);
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                                           Write(price.ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <span>
                                                تومان
                                            </span>
                                        </div>

                                    </a>

                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 98 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <div class=""checkout-to-shipping-sticky"">
                    <a href=""#"" class=""selenium-next-step-shipping"">ادامه فرآیند خرید</a>
                    <div class=""checkout-to-shipping-price-report"">
                        <p>مبلغ قابل پرداخت</p>
                        <div class=""cart-item-product-price"">
");
#nullable restore
#line 106 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                              
                                var totalPrice = Model.Items.Sum(p => p.UnitPrice * p.Quantity);
                                var tax = Math.Round((decimal) (totalPrice * 0.09));
                                var totalPay = tax + totalPrice;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>\r\n                                ");
#nullable restore
#line 112 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                           Write(totalPay.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-3 col-xs-12 pull-left"">
                <div class=""page-aside"">
                    <div class=""checkout-summary"">
                        <ul class=""checkout-summary-summary"">
                            <li>
                                <span>مبلغ کل (");
#nullable restore
#line 123 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                                          Write(Model.Items.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" کالا)</span>\r\n                                <span>\r\n");
            WriteLiteral("                                </span>\r\n                            </li>\r\n                            <li>\r\n                                <span>جمع</span>\r\n                                <span>\r\n                                    ");
#nullable restore
#line 131 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                               Write(Model.Items.Sum(p => p.UnitPrice * p.Quantity).ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان
                                </span>
                            </li>
                            <li>
                                <span style=""color: #424750; font-size:14px;"">هزینه مالیات</span>
                                <span></span>
                            </li>
                            <li>
                                <span><i class=""fa fa-percent""></i>ارزش افزوده %9</span>
                                <span>
                                    ");
#nullable restore
#line 141 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                               Write(tax.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان\r\n                                </span>\r\n                            </li>\r\n                            <li>\r\n                                <span>مبلغ قابل پرداخت</span>\r\n                                <span>");
#nullable restore
#line 146 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
                                 Write(totalPay.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n                            </li>\r\n");
            WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""checkout-summary-content"">
                        <p>کالاهای موجود در سبد شما ثبت نهایی و رزرو نشده‌اند، برای ثبت سفارش مراحل بعدی را تکمیل کنید.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--  cart------------------>
");
            WriteLiteral(@"    <script>
    function SetQuantity(itemId) {
        var quantity = $(""#quantity-""+itemId).val();
        $.ajax({
            type: ""POST"",
            url: ""/basket/setquantity?basketItemId="" + itemId + ""&&quantity="" + quantity,
            success: function () {
                location.reload();
            }
        })
    }
</script>
");
#nullable restore
#line 184 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-12"">
        <div class=""cart-page"">
            <div class=""container"">
                <div class=""checkout-empty"">
                    <div class=""checkout-empty-empty-cart-icon""></div>
                    <div class=""checkout-empty-title"">سبد خرید شما خالی است!</div>
                    <div class=""col-lg-6 col-md-6!important col-xs-12 mx-auto"">
                        <div class=""checkout-empty-links"">

                            <p>
                                می‌توانید برای مشاهده محصولات بیشتر به صفحات زیر بروید
                            </p>
                            <div class=""checkout-empty-link-urls"">
                                <a href=""/product"">
                                    محصولات
                                </a>
                                <a href=""/blog"">
                                    بلاگ
                                </a>
                            </div>
                        </div>
                    </div>");
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 213 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
