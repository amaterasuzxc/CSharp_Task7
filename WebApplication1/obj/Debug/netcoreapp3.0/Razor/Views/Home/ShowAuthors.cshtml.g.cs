#pragma checksum "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f4569b047ef7226d50a89ed4e8ba4854e1e50bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowAuthors), @"mvc.1.0.view", @"/Views/Home/ShowAuthors.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f4569b047ef7226d50a89ed4e8ba4854e1e50bd", @"/Views/Home/ShowAuthors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowAuthors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
  
    ViewData["Title"] = "Authors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2>");
#nullable restore
#line 12 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    <div class=""books-list"">
        <table class=""show-content"">
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Country Of Birth</th>
                <th>Year Of Birth</th>
                <th>Number Of Books</th>
                <th>Controls</th>
            </tr>
");
#nullable restore
#line 23 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
                   Write(item.CountryOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
                   Write(item.YearOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
                   Write(item.Books.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"word-spacing: 1em;\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
                   Write(Html.ActionLink("Edit", "EditAuthor", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 33 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
                   Write(Html.ActionLink("Delete", "DeleteAuthor", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        <div class=\"entry-counter\">\r\n            <p>Total number of entries: ");
#nullable restore
#line 39 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
                                   Write(Model.ToList().Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"buttons\">\r\n        <button class=\"create-button\">\r\n            ");
#nullable restore
#line 44 "C:\Users\igarj\source\repos\WebApplication1\WebApplication1\Views\Home\ShowAuthors.cshtml"
       Write(Html.ActionLink("Create new", "CreateAuthor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </button>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591