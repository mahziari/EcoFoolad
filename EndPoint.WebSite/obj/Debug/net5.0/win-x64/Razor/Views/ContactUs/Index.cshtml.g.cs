#pragma checksum "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29375f4ff458af5ba01c17567857ce2a50af6ec6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactUs_Index), @"mvc.1.0.view", @"/Views/ContactUs/Index.cshtml")]
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
#line 1 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
using Application.Services.FrontEnd.Common.Footers.Queries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
using Application.Services.FrontEnd.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29375f4ff458af5ba01c17567857ce2a50af6ec6", @"/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d0c7bc3adcd10db8d0cbb09ec5ac66abbf68a6", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Entities.Dtos.BaseDto<FooterFrontEndDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "ارتباط با ما";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    <meta name=\"description\" content=\"اکوفولاد ؛ قیمت آهن، خرید و فروش آهن، انواع میلگرد، پروفیل، تیرآهن، ورق، نبشی و ناودانی، آهن آلات، با لیست قیمت‌های روزانه ✦ خرید پیشرو در بازار آهن: ☎ 021\">\r\n    <link rel=\"canonical\"");
                BeginWriteAttribute("href", " href=\"", 532, "\"", 613, 4);
#nullable restore
#line 12 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 539, Context.Request.Scheme, 539, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 562, "://", 562, 3, true);
#nullable restore
#line 12 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 565, Context.Request.Host, 565, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 586, Context.Request.Path.Value, 586, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta property=\"og:locale\" content=\"fa_IR\">\r\n    <meta property=\"og:type\" content=\"article\">\r\n    <meta property=\"og:title\"");
                BeginWriteAttribute("content", " content=\"", 744, "\"", 807, 5);
                WriteAttributeValue("", 754, "ارتباط", 754, 6, true);
                WriteAttributeValue(" ", 760, "با", 761, 3, true);
                WriteAttributeValue(" ", 763, "ما", 764, 3, true);
                WriteAttributeValue(" ", 766, "|", 767, 2, true);
#nullable restore
#line 15 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue(" ", 768, SiteSetting.GetSiteSetting().SiteName, 769, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta property=\"og:description\" content=\"فروشگاه آنلاین محصولات آهن و و فولاد\">\r\n    <meta property=\"og:url\"");
                BeginWriteAttribute("content", " content=\"", 923, "\"", 1007, 4);
#nullable restore
#line 17 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 933, Context.Request.Scheme, 933, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 956, "://", 956, 3, true);
#nullable restore
#line 17 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 959, Context.Request.Host, 959, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 980, Context.Request.Path.Value, 980, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta property=\"og:site_name\"");
                BeginWriteAttribute("content", " content=\"", 1044, "\"", 1092, 1);
#nullable restore
#line 18 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 1054, SiteSetting.GetSiteSetting().SiteName, 1054, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta property=\"article:section\" content=\"ارتباط با ما\">\r\n    <meta name=\"twitter:card\" content=\"summary_large_image\">\r\n    <meta name=\"twitter:site\"");
                BeginWriteAttribute("content", " content=\"", 1249, "\"", 1270, 0);
                WriteLiteral("@");
                WriteLiteral("ecofoolad");
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"twitter:url\"");
                BeginWriteAttribute("content", " content=\"", 1302, "\"", 1386, 4);
#nullable restore
#line 22 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 1312, Context.Request.Scheme, 1312, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1335, "://", 1335, 3, true);
#nullable restore
#line 22 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 1338, Context.Request.Host, 1338, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue("", 1359, Context.Request.Path.Value, 1359, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"twitter:description\" content=\"فروشگاه آنلاین محصولات آهن و و فولاد - ارتباط با ما\">\r\n    <meta name=\"twitter:title\"");
                BeginWriteAttribute("content", " content=\"", 1521, "\"", 1584, 5);
                WriteAttributeValue("", 1531, "ارتباط", 1531, 6, true);
                WriteAttributeValue(" ", 1537, "با", 1538, 3, true);
                WriteAttributeValue(" ", 1540, "ما", 1541, 3, true);
                WriteAttributeValue(" ", 1543, "-", 1544, 2, true);
#nullable restore
#line 24 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
WriteAttributeValue(" ", 1545, SiteSetting.GetSiteSetting().SiteName, 1546, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"twitter:image\" content=\"/Images/Settings/FavIcon/android-icon-192x192.png\"/>\r\n    <meta name=\"twitter:creator\"");
                BeginWriteAttribute("content", " content=\"", 1714, "\"", 1735, 0);
                WriteLiteral("@");
                WriteLiteral("ecofoolad");
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Foo", async() => {
                WriteLiteral("\r\n    <script type=\"application/ld+json\">\r\n        {\r\n        \"");
                WriteLiteral("@context\": \"https://schema.org\",\r\n        \"");
                WriteLiteral("@type\": \"LocalBusiness\",\r\n        \"name\": \"ارتباط با ما - ");
#nullable restore
#line 34 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
                           Write(SiteSetting.GetSiteSetting().SiteName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n        \"image\": \"");
#nullable restore
#line 35 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
             Write(SiteSetting.GetSiteSetting().LogoImage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n        \"");
                WriteLiteral("@id\": \"https://www.ecofoolad.com\",\r\n        \"url\": \"https://www.ecofoolad.com\",\r\n        \"telephone\": \"+982143000550\",\r\n        \"priceRange\": \"IRR\",\r\n        \"address\": {\r\n            \"");
                WriteLiteral(@"@type"": ""PostalAddress"",
            ""streetAddress"": ""یوسف آباد - خیاب سید جمال الدین - بعد از خیابان ۶۵ - پلاک ۴۸۵ - واحد ۴۳ - دفتر اکو فولاد "",
            ""addressLocality"": ""تهران"",
            ""postalCode"": ""1434964737"",
            ""addressCountry"": ""IR""
        },
        ""geo"": {
            """);
                WriteLiteral("@type\": \"GeoCoordinates\",\r\n            \"latitude\": 35.748168,\r\n            \"longitude\": 51.405510\r\n        },\r\n        \"openingHoursSpecification\": {\r\n            \"");
                WriteLiteral(@"@type"": ""OpeningHoursSpecification"",
            ""dayOfWeek"": [
                ""Monday"",
                ""Tuesday"",
                ""Wednesday"",
                ""Thursday"",
                ""Saturday"",
                ""Sunday""
            ],
            ""opens"": ""08:00"",
            ""closes"": ""17:00""
        },
        ""sameAs"": [
            ""https://www.facebook.com/ecofoolad"",
            ""https://www.twitter.com/ecofoolad"",
            ""https://plus.google.com/+ecofoolad"",
            ""https://www.instagram.com/ecofoolad"",
            ""https://www.youtube.com/channel/"",
            ""https://www.linkedin.com/company/ecofoolad""
        ]
    }
    </script>
    <script type=""application/ld+json"">
        {
        """);
                WriteLiteral("@context\": \"https://schema.org\",\r\n        \"");
                WriteLiteral("@type\": \"WebSite\",\r\n        \"url\": \"https://www.ecofoolad.com\",\r\n        \"potentialAction\": {\r\n            \"");
                WriteLiteral("@type\": \"SearchAction\",\r\n            \"target\": \"https://www.ecofoolad.com/search/?q={search_term_string}\",\r\n            \"query-input\": \"required name=search_term_string\"\r\n        }\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""info-page-cover"" style=""background: linear-gradient(rgba(0, 0, 0, .6), rgba(0, 0, 0, .6)), url(/BackEnd/Admin/images/fileManager/2021/2021-7/a5cb3118-baa0-4de1-be39-8d6e1c0be327info-page-cover.jpg) top no-repeat"">
    <div class=""col-lg-12 col-md-12 col-xs-12 mx-auto"">
        <div class=""info-page-cover-title"">
            ارتباط با ما
        </div>
");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"info-page-faq\">\r\n        <div class=\"content-info-page\">\r\n            <div class=\"box-rounded-content\">\r\n                <section class=\"js-expert-article\">\r\n");
            WriteLiteral(@"                    <section class=""contact-us-promo pt-100"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-lg-3 col-md-6 col-sm-6"">
                                    <div class=""card single-promo-card single-promo-hover text-center"">
                                        <div class=""card-body py-5"">
                                            <div class=""pb-2"">
");
            WriteLiteral(@"                                                <i class=""fa fa-mobile contactUsFontLi"" aria-hidden=""true""></i>
                                            </div>
                                            <div>
                                                <h5 class=""mb-0"">تماس با ما</h5>
                                                <p class=""text-muted mb-0"">");
#nullable restore
#line 121 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
                                                                      Write(Model.Data.PhoneNumber1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-3 col-md-6 col-sm-6"">
                                    <div class=""card single-promo-card single-promo-hover text-center"">
                                        <div class=""card-body py-5"">
                                            <div class=""pb-2"">
                                                <i class=""fa fa-map-marker contactUsFontLi"" aria-hidden=""true""></i>
                                            </div>
                                            <div>
                                                <h5 class=""mb-0"">محل ما</h5>
                                                <p class=""text-muted mb-0"">تهران </p>
                                            </div>
                                        </div>
                                    ");
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col-lg-3 col-md-6 col-sm-6"">
                                    <div class=""card single-promo-card single-promo-hover text-center"">
                                        <div class=""card-body py-5"">
                                            <div class=""pb-2"">
                                                <i class=""fa fa-envelope contactUsFontLi"" aria-hidden=""true""></i>
                                            </div>
                                            <div>
                                                <h5 class=""mb-0"">ایمیل ما</h5>
                                                <p class=""text-muted mb-0"">info@ecofoolad.com</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-3 col-md-6 col-sm-6"">
        ");
            WriteLiteral(@"                            <div class=""card single-promo-card single-promo-hover text-center"">
                                        <div class=""card-body py-5"">
                                            <div class=""pb-2"">
                                                <i class=""fa fa-headphones contactUsFontLi""></i>
                                            </div>
                                            <div>
                                                <h5 class=""mb-0"">پشتیبانی ما</h5>
                                                <p class=""text-muted mb-0"">به صورت 24/7</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </section>
            </div>
            
            <div class=""box-rounded-content"">
                <sectio");
            WriteLiteral("n class=\"js-expert-article\">\r\n");
            WriteLiteral(@"                    <section class=""contact-us-promo pt-100"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-lg-12 col-md-12 col-sm-12"">
                                    <div class=""card single-promo-card single-promo-hover text-center"">
                                        <div class=""card-body py-5"">
                                            <div class=""pb-2"">
");
            WriteLiteral(@"                                                <i class=""fa fa-building contactUsFontLi"" aria-hidden=""true""></i>
                                            </div>
                                            <div>
                                                <h5 class=""mb-0"">آدرس دفتر</h5>
                                                <p class=""text-muted mb-0"">");
#nullable restore
#line 188 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
                                                                      Write(Model.Data.OfficeAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-12 col-md-12 col-sm-12"">
                                    <div class=""card single-promo-card single-promo-hover text-center"">
                                        <div class=""card-body py-5"">
                                            <div class=""pb-2"">
                                                <i class=""fa fa-industry contactUsFontLi"" aria-hidden=""true""></i>
                                            </div>
                                            <div>
                                                <h5 class=""mb-0"">آدرس انبار</h5>
                                                <p class=""text-muted mb-0"">");
#nullable restore
#line 201 "C:\Users\pc-2\Pictures\.NET\01_NewMyProject\EndPoint.WebSite\Views\ContactUs\Index.cshtml"
                                                                      Write(Model.Data.FactoryAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                </section>
            </div>
            
            <br>
            <br>
        </div>
    </div>
    <div class=""info-page-faq"">
        <div class=""content-info-page"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d6927.808101182909!2d51.40080786510871!3d35.74674787374283!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2s!4v1628064279833!5m2!1sen!2s"" width=""900"" height=""600"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 11712, "\"", 11730, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Entities.Dtos.BaseDto<FooterFrontEndDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591