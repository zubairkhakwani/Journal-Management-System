#pragma checksum "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32debe41eebd79edd4f2a0e6274701f1345798c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AssociateEditor_Index), @"mvc.1.0.view", @"/Views/AssociateEditor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32debe41eebd79edd4f2a0e6274701f1345798c9", @"/Views/AssociateEditor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261d1804d98ff39377fd12985c97bef143152356", @"/Views/_ViewImports.cshtml")]
    public class Views_AssociateEditor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssociateEditorIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AssociateEditorSideBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "associateeditor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-sm-4\" style=\"padding:35px; \">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32debe41eebd79edd4f2a0e6274701f1345798c95146", async() => {
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
            WriteLiteral(@"
</div>

<div class=""col-sm-8"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Article Id</th>
                <th>Article Type</th>
                <th>Article Title</th>
                <th>Previously Submitted</th>
                <th>Assign Reviewer</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
             foreach (Article article in Model.articles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
                   Write(article.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
                   Write(article.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
                   Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
                      
                        if (article.PreviousSubmittedArticleId == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>No</td>\r\n");
#nullable restore
#line 33 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 36 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
                           Write(article.PreviousSubmittedArticleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32debe41eebd79edd4f2a0e6274701f1345798c99320", async() => {
                WriteLiteral("Assign Reviewer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
                                                                                   WriteLiteral(article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssociateEditorIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
