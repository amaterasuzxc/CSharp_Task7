#pragma checksum "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f602f64b582c90e4211c61ee9148aeb8ee5708df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
#line 1 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f602f64b582c90e4211c61ee9148aeb8ee5708df", @"/Views/Home/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\Create.cshtml"
  
    ViewData["Title"] = "Modifying Books";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h2>");
#nullable restore
#line 10 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\Create.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"creator\">\r\n");
#nullable restore
#line 12 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\Create.cshtml"
         using (Html.BeginForm("Create", "Home"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"input-box\">\r\n                <label>ISBN</label>\r\n                ");
#nullable restore
#line 16 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\Create.cshtml"
           Write(Html.TextBoxFor(o => o.Isbn, new { @class = "text-box" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-box\">\r\n                <label>Title</label>\r\n                ");
#nullable restore
#line 20 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\Create.cshtml"
           Write(Html.TextBoxFor(o => o.Title, new { @class = "text-box" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-box\">\r\n                <label>Year Of Publishing</label>\r\n                ");
#nullable restore
#line 24 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\Create.cshtml"
           Write(Html.TextBoxFor(o => o.Year, "2021", new { type = "number", @class = "text-box" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"input-box\">\r\n                <label>AuthorID</label>\r\n                ");
#nullable restore
#line 28 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\Create.cshtml"
           Write(Html.TextBoxFor(o => o.AuthorId, new { type = "number", @class = "text-box" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"submit-button\">\r\n                <input type=\"submit\" value=\"Submit\" />\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
