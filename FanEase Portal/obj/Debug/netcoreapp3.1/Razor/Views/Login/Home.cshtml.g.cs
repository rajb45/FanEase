#pragma checksum "C:\Users\X270\source\FanEase\FanEase-Portal\FanEase Portal\Views\Login\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3250b6da507a3940e12ac891abf1f1beb1df08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Home), @"mvc.1.0.view", @"/Views/Login/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3250b6da507a3940e12ac891abf1f1beb1df08", @"/Views/Login/Home.cshtml")]
    public class Views_Login_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\X270\source\FanEase\FanEase-Portal\FanEase Portal\Views\Login\Home.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3250b6da507a3940e12ac891abf1f1beb1df084178", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e3250b6da507a3940e12ac891abf1f1beb1df084440", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css\" rel=\"stylesheet\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e3250b6da507a3940e12ac891abf1f1beb1df085732", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3250b6da507a3940e12ac891abf1f1beb1df087724", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <a class=""navbar-brand"">FanEase</a>

        <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo03"">
            <ul class=""navbar-nav mr-auto mt-2 mt-lg-0"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""#about-us"">About Us</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#containercontact"">Contact Us</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Privacy</a>
                </li>
            </ul>
            <form class=""form-inline"">
                <input type=""submit""");
                BeginWriteAttribute("class", " class=\"", 1178, "\"", 1186, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Sign In\">\r\n            </form>\r\n            <form class=\"form-inline\" action=\"index\">\r\n                <input type=\"submit\"");
                BeginWriteAttribute("class", " class=\"", 1318, "\"", 1326, 0);
                EndWriteAttribute();
                WriteLiteral(@" value=""Log In"">
            </form>
        </div>

    </nav>

    <div id=""carouselExampleDark"" class=""carousel carousel-dark slide"" data-bs-ride=""carousel"">
        <div class=""carousel-inner"">
            <div class=""carousel-item active"" data-bs-interval=""10000"">
                <img src=""https://drive.google.com/uc?export=view&id=1pwXVQZ6WGohZwKErui92vILjpkNGWRCk"" class=""d-block w-100"" alt=""..."">

            </div>
            <div class=""carousel-item"" data-bs-interval=""2000"">
                <img src=""https://drive.google.com/uc?export=view&id=1pwXVQZ6WGohZwKErui92vILjpkNGWRCk"" class=""d-block w-100"" alt=""..."">

            </div>
            <div class=""carousel-item"">
                <img src=""https://drive.google.com/uc?export=view&id=1pwXVQZ6WGohZwKErui92vILjpkNGWRCk"" class=""d-block w-100"" alt=""..."">

            </div>
        </div>
        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleDark"" data-bs-slide=""prev"">
            <span clas");
                WriteLiteral(@"s=""carousel-control-prev-icon visually-hidden"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Previous</span>
        </button>
        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleDark"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon visually-hidden"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
        </button>
    </div>

   
    <div class=""container mt-3"" id=""about-us"">
        <div class=""col-sm-6"">
            <div class=""card border-0"">
                <div class=""card-body"">
                    <h5 class=""card-title"">FANEASE</h5>
                    <p class=""card-text"">FanEase is a technology platform that transforms existing broadcast real estate into a landscape of digital video advertising units that are utilized to strengthen the connection between brands and users.</p>
                    <a href=""#"" class=""btn btn-primary"">Learn More</a>
                </");
                WriteLiteral(@"div>
            </div>
        </div>
    </div>
   

    <div class=""container mt-3"">
        <div class=""row justify-content-end"">
            <div class=""col-sm-6"">
                <div class=""card border-0"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">
                            The Age of Information
                            <br>
                            and Connectivity
                        </h5>
                        <p class=""card-text"">
                            With new channels and content types constantly emerging Brands and Content Creators are seeking new stratagies in order to grow, engage and sell merchandise to their audience.
                        </p>
                        <a href=""#"" class=""btn btn-primary"">Download Guide</a>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""container mt-3"">
        <div class=""row justify-content-star");
                WriteLiteral(@"t"">
            <div class=""col-sm-12"">
                <div class=""card border-0"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">
                            Empowering the Creative Types
                        </h5>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""container mt-3"">
        <div class=""row row-cols-1 row-cols-md-3 g-4"">
            <div class=""col"" style=""width: 20rem;"">
                <div class=""card h-100 border-0"">
                    <img src=""https://www.nannybag.com/_nuxt/img/1.ff3f5fb.png"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body text-center"">
                        <h5 class=""card-title"">Brands</h5>
                    </div>

                </div>
            </div>
            <div class=""col"" style=""width: 20rem;"">
                <div class=""card h-100 border-0"">
                    <img src=""https://www.nannyba");
                WriteLiteral(@"g.com/_nuxt/img/1.ff3f5fb.png"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body text-center"">
                        <h5 class=""card-title"">Content Creators</h5>
                    </div>

                </div>
            </div>
            <div class=""col"" style=""width: 20rem;"">
                <div class=""card h-100 border-0"">
                    <img src=""https://www.nannybag.com/_nuxt/img/1.ff3f5fb.png"" class=""card-img-top"" alt=""..."">
                    <div class=""card-body text-center"">
                        <h5 class=""card-title"">Agencies</h5>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""container contact"" id=""containercontact"">
        <div class=""row"">
            <div class=""col-md-3"" id=""contact-us"">
                <div class=""contact-info"">
                    <img src=""https://image.ibb.co/kUASdV/contact-image.png"" alt=""image"" /><br>
                    <h2>Contact Us</h2>
 ");
                WriteLiteral(@"                   <h4>We would love to hear from you !</h4>
                </div>
            </div>
            <div class=""col-md-9"">
                <div class=""contact-form"">
                    <div class=""form-group"">
                        <label class=""control-label col-sm-2"" for=""fname"">First Name:</label>
                        <div class=""col-sm-10"">
                            <input type=""text"" class=""form-control"" id=""fname"" placeholder=""Enter First Name"" name=""fname"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label col-sm-2"" for=""lname"">Last Name:</label>
                        <div class=""col-sm-10"">
                            <input type=""text"" class=""form-control"" id=""lname"" placeholder=""Enter Last Name"" name=""lname"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""contro");
                WriteLiteral(@"l-label col-sm-2"" for=""email"">Email:</label>
                        <div class=""col-sm-10"">
                            <input type=""email"" class=""form-control"" id=""email"" placeholder=""Enter email"" name=""email"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label col-sm-2"" for=""comment"">Comment:</label>
                        <div class=""col-sm-10"">
                            <textarea class=""form-control"" rows=""5"" id=""comment""></textarea>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-sm-offset-2 col-sm-10"">
                            <button type=""submit"" class=""btn btn-default"">Submit</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <footer class=""bg-light text-center text-lg-start"">

        <d");
                WriteLiteral("iv class=\"text-center p-3\" style=\"background-color: rgba(0, 0, 0, 0.2);\">\r\n            © 2020 Copyright:\r\n            <a class=\"text-dark\" href=\"www.fanease.com\">fanease.com</a>\r\n        </div>\r\n\r\n    </footer>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
