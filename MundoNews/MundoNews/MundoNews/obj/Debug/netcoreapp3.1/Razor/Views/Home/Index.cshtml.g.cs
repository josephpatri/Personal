#pragma checksum "C:\Users\odali\source\repos\josephpatri\Personal\MundoNews\MundoNews\MundoNews\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3de057f10972b8903c4679ffc252e74ed84a2dfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\odali\source\repos\josephpatri\Personal\MundoNews\MundoNews\MundoNews\Views\_ViewImports.cshtml"
using MundoNews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\odali\source\repos\josephpatri\Personal\MundoNews\MundoNews\MundoNews\Views\_ViewImports.cshtml"
using MundoNews.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de057f10972b8903c4679ffc252e74ed84a2dfd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebcabff429e7549878a7a0da7f35a0a5bcde8efd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MundoNews.Models.DataObjects.NewsObject>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\odali\source\repos\josephpatri\Personal\MundoNews\MundoNews\MundoNews\Views\Home\Index.cshtml"
      
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<div class=\"news text-center\">\r\n");
#nullable restore
#line 12 "C:\Users\odali\source\repos\josephpatri\Personal\MundoNews\MundoNews\MundoNews\Views\Home\Index.cshtml"
     foreach (var noticia in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row justify-content-center\">\r\n            <div class=\"col-8\">\r\n                <h1>");
#nullable restore
#line 16 "C:\Users\odali\source\repos\josephpatri\Personal\MundoNews\MundoNews\MundoNews\Views\Home\Index.cshtml"
               Write(noticia.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 544, "\"", 565, 1);
#nullable restore
#line 19 "C:\Users\odali\source\repos\josephpatri\Personal\MundoNews\MundoNews\MundoNews\Views\Home\Index.cshtml"
WriteAttributeValue("", 550, noticia.ImgUrl, 550, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Ir a la noticia\" />\r\n        <br /><br /><br /><br />\r\n        <div class=\"row justify-content-center\">\r\n            <div class=\"col-8\">\r\n                <p>");
#nullable restore
#line 23 "C:\Users\odali\source\repos\josephpatri\Personal\MundoNews\MundoNews\MundoNews\Views\Home\Index.cshtml"
              Write(noticia.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <br /><br />\r\n");
#nullable restore
#line 27 "C:\Users\odali\source\repos\josephpatri\Personal\MundoNews\MundoNews\MundoNews\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MundoNews.Models.DataObjects.NewsObject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
