#pragma checksum "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8057ba381240ff9a8d6f3bb2aa4554c5e4488074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_ShippingPayment), @"mvc.1.0.view", @"/Views/Basket/ShippingPayment.cshtml")]
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
#line 1 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
using EndPoint.WebSite.Models.ViewModel.Baskets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
using Application.Services.FrontEnd.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8057ba381240ff9a8d6f3bb2aa4554c5e4488074", @"/Views/Basket/ShippingPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d0c7bc3adcd10db8d0cbb09ec5ac66abbf68a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_ShippingPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShippingPaymentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShippingPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
  
    ViewData["Title"] = "????????????";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--shopping--------------------->\r\n\r\n    <section class=\"shopping-page\">\r\n        <div class=\"container\">\r\n            <div class=\"header-shopping-logo\">\r\n                <a href=\"#\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 466, "\"", 511, 1);
#nullable restore
#line 17 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
WriteAttributeValue("", 472, SiteSetting.GetSiteSetting().LogoImage, 472, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Logo""></a>
            </div>
        </div>

        <div class=""container"">
            <div class=""row"">
                <ul class=""checkout-steps"">
                    <li class=""is-completed is-completed-active"">
                        <a href=""shopping.html"" class=""checkout-steps-item-link active-link-shopping"">
                            <span>?????????????? ??????????</span>
                        </a>
                    </li>
                    <li class=""is-completed"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 1034, "\"", 1041, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"checkout-steps-item-link active-link-shopping\">\r\n                            <span>????????????</span>\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"is-active\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1275, "\"", 1282, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"checkout-steps-item active-link\">\r\n                            <span>?????????? ???????? ?? ??????????</span>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8057ba381240ff9a8d6f3bb2aa4554c5e44880746421", async() => {
                WriteLiteral(@"
    <div class=""main-shopping"">
            <div class=""content-shopping"">
                <div class=""col-lg-9 col-md-9 col-xs-12 pull-right"">
                    <div class=""shipment-page-container"">
                        <div class=""headline-checkout-shopping"">
                            <span>???????????? ????????</span>
                        </div>
                        <div class=""payment"">
                            <ul class=""checkout-paymethod"">
");
#nullable restore
#line 53 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                   var i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                 foreach (var item in Model.UserAddresses)
                                {
                                    i++;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <li class=""wallet-container"">
                                        <div class=""checkout-paymethod-item"">
                                            <span class=""mdi mdi-card-text-outline""></span>
                                            <label");
                BeginWriteAttribute("for", " for=\"", 2527, "\"", 2549, 2);
                WriteAttributeValue("", 2533, "address-", 2533, 8, true);
#nullable restore
#line 60 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
WriteAttributeValue("", 2541, item.Id, 2541, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"radio-primary\">\r\n                                                <input");
                BeginWriteAttribute("id", " id=\"", 2629, "\"", 2650, 2);
                WriteAttributeValue("", 2634, "address-", 2634, 8, true);
#nullable restore
#line 61 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
WriteAttributeValue("", 2642, item.Id, 2642, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"radio\" name=\"address\"");
                BeginWriteAttribute("value", " value=\"", 2679, "\"", 2695, 1);
#nullable restore
#line 61 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
WriteAttributeValue("", 2687, item.Id, 2687, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\"", 2696, "\"", 2732, 1);
#nullable restore
#line 61 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
WriteAttributeValue("", 2706, i == 0 ? "checked" : "", 2706, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                <span class=""ui-radio-check""></span>
                                            </label>
                                            <h4 class=""checkout-paymethod-title"">
                                                <p class=""checkout-paymethod-title-label"">??????????: ");
#nullable restore
#line 65 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                                                                            Write(item.PostalAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                <div class=\"paymethod-wallet-amount\">\r\n                                                    <span>?????? ????????????:</span>\r\n");
                WriteLiteral("                                                    <span class=\"checkout-paymethod-currency\">");
#nullable restore
#line 69 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                                                                         Write(item.ReciverName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                                </div>
                                            </h4>
                                            <div class=""wallet-extra-info"">
                                                <span class=""wallet-needed-money""></span>
                                                ");
#nullable restore
#line 74 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                           Write(item.City);

#line default
#line hidden
#nullable disable
                WriteLiteral("-");
#nullable restore
#line 74 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                                      Write(item.State);

#line default
#line hidden
#nullable disable
                WriteLiteral("-");
#nullable restore
#line 74 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                                                  Write(item.PostalAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("-");
#nullable restore
#line 74 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                                                                      Write(item.ZipCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"checkout-paymethod-by-digipay\">\r\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 4036, "\"", 4090, 1);
#nullable restore
#line 77 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
WriteAttributeValue("", 4042, SiteSetting.GetSiteSetting().ThumbnailLogoImage, 4042, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            </div>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 81 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                        </div>\r\n");
                WriteLiteral("                        <div class=\"checkout-order-summary\">\r\n");
                WriteLiteral(@"                            <div class=""checkout-to-shipping-sticky"">
                                <button type=""submit"" class=""selenium-next-step-shipping"">?????????? ???????????? ????????</button>
                                <div class=""checkout-to-shipping-price-report"">
                                    <p>???????? ???????? ????????????</p>
");
#nullable restore
#line 134 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                        
                                        var totalPrice = Model.basket.Items.Sum(p => p.UnitPrice * p.Quantity);
                                        var tax = Math.Round((decimal) (totalPrice * 0.09));
                                        var totalPay = (tax + totalPrice).ToString("n0");
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"cart-item-product-price\">\r\n                                        ");
#nullable restore
#line 140 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                   Write(totalPay);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <span>??????????</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n    \r\n    \r\n");
                WriteLiteral("    \r\n    \r\n    \r\n                    <div class=\"checkout-actions\">\r\n                        <a href=\"/basket\" class=\"btn-link-spoiler\">\r\n                            ?? ???????????? ???? ?????? ????????\r\n                        </a>\r\n");
                WriteLiteral(@"                    </div>
                </div>
    
                <div class=""col-lg-3 col-md-3 col-xs-12 pull-left"">
                    <div class=""page-aside"" style=""margin-top: 95px;"">
                        <div class=""checkout-summary"">
                            <ul class=""checkout-summary-summary"">
                                <li>
                                    <span>???????? ???? (");
#nullable restore
#line 187 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                              Write(Model.basket.Items.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</span>\r\n                                    <span>");
#nullable restore
#line 188 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                     Write(totalPay);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ??????????</span>\r\n                                </li>\r\n");
                WriteLiteral("                                <li>\r\n                                    <span>???????? ???????? ????????????</span>\r\n                                    <span>");
#nullable restore
#line 204 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\Basket\ShippingPayment.cshtml"
                                     Write(totalPay);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ??????????</span>\r\n                                </li>\r\n");
                WriteLiteral(@"                            </ul>
                        </div>
                        <div class=""checkout-summary-content"">
                            <p>?????????????? ?????????? ???? ?????? ?????? ?????? ?? ???????? ??????????????????? ???????? ?????? ?????????? ?????????? ???????? ???? ?????????? ????????.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n    <!--shopping--------------------->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISiteSetting SiteSetting { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShippingPaymentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
