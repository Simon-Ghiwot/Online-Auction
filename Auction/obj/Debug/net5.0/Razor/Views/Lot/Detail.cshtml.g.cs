#pragma checksum "C:\Users\sidona\Online-Auction\Auction\Views\Lot\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b41f6e59058d25277890e22e7e3723014cff9fac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lot_Detail), @"mvc.1.0.view", @"/Views/Lot/Detail.cshtml")]
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
#line 1 "C:\Users\sidona\Online-Auction\Auction\Views\_ViewImports.cshtml"
using Auction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sidona\Online-Auction\Auction\Views\_ViewImports.cshtml"
using Auction.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41f6e59058d25277890e22e7e3723014cff9fac", @"/Views/Lot/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d48aafa155944a2cbfa352e55b0966fdaeaa49ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Lot_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auction.Models.Lot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/aspnet/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bid.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<section class=\"d-flex flex-row bd-highlight\" style=\"justify-content: space-evenly\">\r\n    <div>\r\n        <image");
            BeginWriteAttribute("src", " src=\"", 138, "\"", 162, 2);
            WriteAttributeValue("", 144, "/", 144, 1, true);
#nullable restore
#line 4 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\Detail.cshtml"
WriteAttributeValue("", 145, Model.PictureUrl, 145, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail \" style=\"width: 400px; height: 400px\"/>\r\n    </div>\r\n    <div style=\"align-self: center;\">\r\n        <p>Lot Name : ");
#nullable restore
#line 7 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\Detail.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n        <p>Initial Price : ");
#nullable restore
#line 8 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\Detail.cshtml"
                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" birr</p>\r\n");
#nullable restore
#line 9 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\Detail.cshtml"
         if (@ViewBag.show == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <label for =\"bid\">Enter your bid : </label>\r\n                <input id = \"bid\" name=\"bid\" type = \"text\"/>\r\n                <input type=\"button\" value=\"Submit\" id=\"send\"/>\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        Best price : <span id=\"showBestPrice\">");
#nullable restore
#line 17 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\Detail.cshtml"
                                         Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" birr</span>\r\n        <div id=\"DisplayError\" style=\"color : red\"></div>\r\n    </div>\r\n    <span id=\"lotId\" style=\"display: none\">");
#nullable restore
#line 20 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\Detail.cshtml"
                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41f6e59058d25277890e22e7e3723014cff9fac6267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41f6e59058d25277890e22e7e3723014cff9fac7306", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Auction.Models.Lot> Html { get; private set; }
    }
}
#pragma warning restore 1591
