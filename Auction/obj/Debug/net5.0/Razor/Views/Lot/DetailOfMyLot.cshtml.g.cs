#pragma checksum "C:\Users\sidona\Online-Auction\Auction\Views\Lot\DetailOfMyLot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10b7afc464865bf39d4d7624b32955853b58b459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lot_DetailOfMyLot), @"mvc.1.0.view", @"/Views/Lot/DetailOfMyLot.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b7afc464865bf39d4d7624b32955853b58b459", @"/Views/Lot/DetailOfMyLot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d48aafa155944a2cbfa352e55b0966fdaeaa49ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Lot_DetailOfMyLot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auction.Models.Lot>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"d-flex flex-row bd-highlight\" style=\"justify-content: space-evenly\">\r\n    <div>\r\n        <image");
            BeginWriteAttribute("src", " src=\"", 138, "\"", 162, 2);
            WriteAttributeValue("", 144, "/", 144, 1, true);
#nullable restore
#line 4 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\DetailOfMyLot.cshtml"
WriteAttributeValue("", 145, Model.PictureUrl, 145, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail \" style=\"width: 400px; height: 400px\"/>\r\n        <p>Name : ");
#nullable restore
#line 5 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\DetailOfMyLot.cshtml"
             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Price : ");
#nullable restore
#line 6 "C:\Users\sidona\Online-Auction\Auction\Views\Lot\DetailOfMyLot.cshtml"
              Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</section>");
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
