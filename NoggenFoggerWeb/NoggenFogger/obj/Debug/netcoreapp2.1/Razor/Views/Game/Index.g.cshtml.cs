#pragma checksum "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ae5d1a21fdac72df2937265bf65a8e4b396cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/Index.cshtml", typeof(AspNetCore.Views_Game_Index))]
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
#line 1 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\_ViewImports.cshtml"
using NoggenFogger;

#line default
#line hidden
#line 2 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\_ViewImports.cshtml"
using NoggenFogger.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ae5d1a21fdac72df2937265bf65a8e4b396cb6", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa1bfa66d08fb5555c92ff5d4dd00d9bc48b87ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<GameViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
   string description = "";

#line default
#line hidden
            BeginContext(65, 29, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n");
            EndContext();
#line 6 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
     foreach (var game in Model)
    {

#line default
#line hidden
            BeginContext(135, 82, true);
            WriteLiteral("        <div class=\"movie-card\">\r\n            <div class=\"movie-header manOfSteel\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 217, "\"", 262, 4);
            WriteAttributeValue("", 225, "background-image:", 225, 17, true);
            WriteAttributeValue(" ", 242, "url(", 243, 5, true);
#line 9 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
WriteAttributeValue("", 247, game.ImageUrl, 247, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 261, ")", 261, 1, true);
            EndWriteAttribute();
            BeginContext(263, 78, true);
            WriteLiteral(">\r\n                <div class=\"header-icon-container\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 341, "\"", 366, 1);
#line 11 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
WriteAttributeValue("", 348, game.VideoTrailer, 348, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(367, 393, true);
            WriteLiteral(@" target=""_blank"">
                        <i class=""material-icons header-icon"">&#xE037;</i>
                    </a>
                </div>
            </div>
            <div class=""movie-content"">
                <div class=""movie-content-header"">
                    <a href="""" style=""text-decoration:none;"">
                        <h3 class=""movie-title"" style=""color:orangered"">");
            EndContext();
            BeginContext(761, 10, false);
#line 19 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
                                                                   Write(game.Title);

#line default
#line hidden
            EndContext();
            BeginContext(771, 248, true);
            WriteLiteral("</h3>\r\n\r\n                    </a>\r\n                </div>\r\n                <div class=\"movie-info\">\r\n                    <div class=\"info-section\" style=\"height:50px;\">\r\n                        <label>Author</label>\r\n                        <small>");
            EndContext();
            BeginContext(1020, 11, false);
#line 26 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
                          Write(game.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 117, true);
            WriteLiteral("</small>\r\n                        <label>NoggenFoggered</label>\r\n                        <small style=\"color:black;\">");
            EndContext();
            BeginContext(1149, 15, false);
#line 28 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
                                               Write(game.LikesCount);

#line default
#line hidden
            EndContext();
            BeginContext(1164, 165, true);
            WriteLiteral("</small>\r\n                        <button id=\"likeButton\" onclick=\"myFunction(this)\" data-toggle=\"popover\" data-trigger=\"hover\" data-content=\"NoggenFogger your game\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1329, "\"", 1348, 1);
#line 29 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
WriteAttributeValue("", 1337, game.Title, 1337, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1349, 328, true);
            WriteLiteral(@">
                            <i class=""fa fa-flask""></i>
                        </button>
                    </div>
                    <div class=""pre-scrollable"" style=""margin-left:20px; height: 100px;"">
                        <label>Description</label>
                        <br />
                        <span>");
            EndContext();
            BeginContext(1678, 16, false);
#line 36 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
                         Write(game.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1694, 97, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 41 "C:\Users\Nikolay Danev\source\repos\NoggenFoggerWeb\NoggenFogger\Views\Game\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1798, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<GameViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591