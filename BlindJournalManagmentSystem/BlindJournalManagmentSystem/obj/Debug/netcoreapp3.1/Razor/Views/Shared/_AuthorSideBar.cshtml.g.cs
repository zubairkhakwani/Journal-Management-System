#pragma checksum "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Shared\_AuthorSideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf7112be79be9e971673a2b4df16beaa0979b1c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AuthorSideBar), @"mvc.1.0.view", @"/Views/Shared/_AuthorSideBar.cshtml")]
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
#line 1 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\_ViewImports.cshtml"
using BlindJournalManagmentSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\_ViewImports.cshtml"
using BlindJournalManagmentSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\_ViewImports.cshtml"
using BlindJournalManagmentSystem.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\_ViewImports.cshtml"
using BlindJournalManagmentSystem.ViewModels.Review;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf7112be79be9e971673a2b4df16beaa0979b1c0", @"/Views/Shared/_AuthorSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261d1804d98ff39377fd12985c97bef143152356", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AuthorSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-bordered table-hover\" style=\"width:280px; margin-left:50px;\">\r\n    <thead>\r\n        <tr>\r\n            <th><b>Submission</b></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 248, "\"", 286, 1);
#nullable restore
#line 10 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Shared\_AuthorSideBar.cshtml"
WriteAttributeValue("", 255, Url.Action("stepone","author"), 255, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;"">
                    step 1: Type, Title, & Abstract
                    <span class=""glyphicon glyphicon-chevron-right""></span>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a");
            BeginWriteAttribute("href", " href=\"", 556, "\"", 594, 1);
#nullable restore
#line 18 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Shared\_AuthorSideBar.cshtml"
WriteAttributeValue("", 563, Url.Action("steptwo","author"), 563, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;"">
                    step 2: File Upload 
                    <span class=""glyphicon glyphicon-chevron-right""></span>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a");
            BeginWriteAttribute("href", " href=\"", 853, "\"", 893, 1);
#nullable restore
#line 26 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Shared\_AuthorSideBar.cshtml"
WriteAttributeValue("", 860, Url.Action("stepthree","author"), 860, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;"">
                    step 3: Attributes 
                    <span class=""glyphicon glyphicon-chevron-right""></span>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a");
            BeginWriteAttribute("href", " href=\"", 1151, "\"", 1190, 1);
#nullable restore
#line 34 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Shared\_AuthorSideBar.cshtml"
WriteAttributeValue("", 1158, Url.Action("stepfour","author"), 1158, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;"">
                    step 4: Authors & Institutions 
                    <span class=""glyphicon glyphicon-chevron-right""></span>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a");
            BeginWriteAttribute("href", " href=\"", 1460, "\"", 1499, 1);
#nullable restore
#line 42 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Shared\_AuthorSideBar.cshtml"
WriteAttributeValue("", 1467, Url.Action("stepfive","author"), 1467, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;\">\r\n                    step 5: Reviewers\r\n                    <span class=\"glyphicon glyphicon-chevron-right\"></span>\r\n                </a>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1755, "\"", 1793, 1);
#nullable restore
#line 50 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Shared\_AuthorSideBar.cshtml"
WriteAttributeValue("", 1762, Url.Action("stepsix","author"), 1762, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;"">
                    step 6: Details & Comments 
                    <span class=""glyphicon glyphicon-chevron-right""></span>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a");
            BeginWriteAttribute("href", " href=\"", 2059, "\"", 2099, 1);
#nullable restore
#line 58 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Shared\_AuthorSideBar.cshtml"
WriteAttributeValue("", 2066, Url.Action("stepseven","author"), 2066, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;\">\r\n                    step 7: Review & Submit \r\n                    <span class=\"glyphicon glyphicon-chevron-right\"></span>\r\n                </a>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
