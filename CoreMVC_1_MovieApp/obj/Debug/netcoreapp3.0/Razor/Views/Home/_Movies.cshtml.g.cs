#pragma checksum "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c56be2e539890b61b41d4b5ea078b87f908cb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Movies), @"mvc.1.0.view", @"/Views/Home/_Movies.cshtml")]
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
#line 1 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\_ViewImports.cshtml"
using CoreMVC_1_MovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\_ViewImports.cshtml"
using CoreMVC_1_MovieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c56be2e539890b61b41d4b5ea078b87f908cb3", @"/Views/Home/_Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b693d8853550d19113fc3671e6c806e561fae980", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml"
 foreach (var movie in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-3\">\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"col-md-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90c56be2e539890b61b41d4b5ea078b87f908cb34084", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 192, "~/img/", 192, 6, true);
#nullable restore
#line 8 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml"
AddHtmlAttributeValue("", 198, movie.ImageUrl, 198, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml"
AddHtmlAttributeValue("", 220, movie.Description, 220, 18, false);

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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 429, "\"", 459, 2);
            WriteAttributeValue("", 436, "/Home/Details/", 436, 14, true);
#nullable restore
#line 13 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml"
WriteAttributeValue("", 450, movie.Id, 450, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml"
                                                     Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                    </h5>\r\n                    <p class=\"card-text\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml"
                   Write(movie.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p class=\"card-text\">\r\n");
#nullable restore
#line 20 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml"
                          
                            var random = new Random();
                            int randomDay = random.Next(1, 10);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <small class=\"text-muted\">");
#nullable restore
#line 24 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml"
                                             Write(randomDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days ago.</small>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\_Movies.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
