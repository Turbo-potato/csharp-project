#pragma checksum "F:\csharp-own-project\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07961c8247e9be4f165d8847dadc933069ceeb44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07961c8247e9be4f165d8847dadc933069ceeb44", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aspnetfirst.Models.Match>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "F:\csharp-own-project\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 234, true);
            WriteLiteral("\n<h2>Index</h2>\n\n\n<h3>Matches</h3>\n<table>\n    <thead>\n        <tr>\n            <th>Name_of_person</th>\n            <th>TeamHomeName</th>\n            <th>TeamGuestName</th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 21 "F:\csharp-own-project\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
             foreach (var Item in Model)
            {
                
                

#line default
#line hidden
#line 24 "F:\csharp-own-project\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                 foreach (var user in Item.UserMatches)
                {

#line default
#line hidden
            BeginContext(464, 49, true);
            WriteLiteral("                    <tr>\n                    <td>");
            EndContext();
            BeginContext(514, 44, false);
#line 27 "F:\csharp-own-project\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(model => user.User.Username));

#line default
#line hidden
            EndContext();
            BeginContext(558, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(589, 49, false);
#line 28 "F:\csharp-own-project\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(model => Item.Team_home.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(638, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(669, 50, false);
#line 29 "F:\csharp-own-project\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(model => Item.Team_guest.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(719, 32, true);
            WriteLiteral("</td>\n                    </tr>\n");
            EndContext();
#line 31 "F:\csharp-own-project\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                 }

#line default
#line hidden
#line 31 "F:\csharp-own-project\aspnetfirst\aspnetfirst\Views\Users\Index.cshtml"
                  

            }

#line default
#line hidden
            BeginContext(785, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aspnetfirst.Models.Match>> Html { get; private set; }
    }
}
#pragma warning restore 1591