#pragma checksum "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21258aff1cec1d74d0779d3c38257f67dd450d88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21258aff1cec1d74d0779d3c38257f67dd450d88", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b693d8853550d19113fc3671e6c806e561fae980", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieCategoryModel>
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
#line 3 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 9 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml"
   Write(await Html.PartialAsync("_Menu", Model.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"card mb-3\">\r\n            <div class=\"card-body\">\r\n                <div class=\"row no-gutters\">\r\n                    <div class=\"col-md-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "21258aff1cec1d74d0779d3c38257f67dd450d884636", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 484, "~/img/", 484, 6, true);
#nullable restore
#line 17 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 490, Model.Movie.ImageUrl, 490, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml"
AddHtmlAttributeValue("", 518, Model.Movie.Description, 518, 24, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        <h5 class=\"card-title\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 716, "\"", 752, 2);
            WriteAttributeValue("", 723, "/Home/Details/", 723, 14, true);
#nullable restore
#line 21 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml"
WriteAttributeValue("", 737, Model.Movie.Id, 737, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml"
                                                               Write(Model.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h5>\r\n                        <p class=\"card-text\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml"
                       Write(Html.Raw(Model.Movie.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p class=\"card-text\">\r\n");
#nullable restore
#line 27 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml"
                              
                                var random = new Random();
                                int randomDay = random.Next(1, 10);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small class=\"text-muted\">");
#nullable restore
#line 31 "C:\Users\casper\Desktop\Files\Applications\C#\Web Applications\ASP.NET Core MVC\CoreMVC_1_MovieApp\CoreMVC_1_MovieApp\Views\Home\Details.cshtml"
                                                 Write(randomDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days ago.</small>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
