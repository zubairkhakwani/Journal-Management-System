#pragma checksum "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52eb7c720b1766e3fedc6009d33cd5725dc5e5be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_stepFour), @"mvc.1.0.view", @"/Views/Author/stepFour.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52eb7c720b1766e3fedc6009d33cd5725dc5e5be", @"/Views/Author/stepFour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261d1804d98ff39377fd12985c97bef143152356", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_stepFour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlindJournalManagmentSystem.ViewModels.StepFourViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AuthorSideBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_FormValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/stepFourAddAuthor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
  
    ViewBag.Title = "stepFour";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-4\" style=\"padding:35px; \">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52eb7c720b1766e3fedc6009d33cd5725dc5e5be5466", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n<div class=\"col-sm-8\">\r\n    <div id=\"4\">\r\n");
#nullable restore
#line 12 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
         using (Html.BeginForm("stepfour", "Author", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52eb7c720b1766e3fedc6009d33cd5725dc5e5be7035", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"            <h1> <small>Step 4: Authors & Institutions</small></h1>
            <p>Enter your co-authors' information in the boxes below, then click ""Add to My Authors."" To check if an author already exists in the journal's database, enter the author's e-mail address and click ""Find."" If the author is found, their information will be automatically filled out for you. When you are finished, click ""Save and Continue.""</p>
            <br>
            <p>Author lists should be carefully considered. To determine what constitutes authorship, please visit: IEEE Definitions of Authorship. Changes to the author list post acceptance are not allowed.</p>
            <br>
            <p>IEEE Access requires that all authors listed on a manuscript have an ORCID iD associated with their ScholarOne Manuscripts account.</p>
            <p> <b>ALL AUTHORS LISTED ON YOUR MANUSCRIPT MUST BE ENTERED HERE</b></p>
            <p> <span class=""required"">*</span>=Required Fields</p><hr class=""hr""><br>
");
            WriteLiteral(@"            <h1> <small>Author</small></h1>
            <h1><small><span class=""required"">*</span> Selected Authors</small></h1>
            <table class=""table table-striped"" id=""authors"">
                <thead>
                    <tr>
                        <th>ORDER</th>
                        <th>ACTIONS</th>
                        <th>AUTHORS</th>
                        <th>INSTITUTION</th>
                    </tr>
                </thead>
                <tbody id=""addAuthorBody"">
");
#nullable restore
#line 37 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
                     if (Model.AuthorsEmails != null)
                    {
                        for (int i = 0; i < Model.AuthorsEmails.Count(); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td></td>\r\n                                <td>\r\n");
#nullable restore
#line 44 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
                                     if (i != 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<button type=\"button\" class=\"btn btn-danger\"> remove </button>");
#nullable restore
#line 45 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
                                                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    <input type=\"hidden\" name=\"AuthorsEmails\"");
            BeginWriteAttribute("value", " value=\"", 2568, "\"", 2609, 1);
#nullable restore
#line 48 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
WriteAttributeValue("", 2576, Model.AuthorsEmails.ElementAt(i), 2576, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    ");
#nullable restore
#line 49 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
                               Write(Model.AuthorsEmails.ElementAt(i));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 51 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
                                Write(Model.AuthorsInstitutions.ElementAt(i));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </tbody>
            </table><hr class=""hr"">
            <h3><small><b>Add Author</b></small></h3>
            <p>Find using Author's email address</p>
            <div class=""input-group"">
                <input type=""email"" class=""form-control"" placeholder=""AuthorEmail@example.com"" name=""search"" id=""search"">
                <div class=""input-group-btn"">
                    <button type=""button"" class=""btn btn-primary"" id=""searchButton""> <i class=""glyphicon glyphicon-search""></i> Search</button>
                </div>
            </div>
            <br>
            <br>
            <hr class=""hr"">
            <button type=""submit"" class=""btn btn-primary pull-right"">Save & Continue <span class=""glyphicon glyphicon-chevron-right""></span> </button>
");
#nullable restore
#line 70 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepFour.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52eb7c720b1766e3fedc6009d33cd5725dc5e5be13882", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlindJournalManagmentSystem.ViewModels.StepFourViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
