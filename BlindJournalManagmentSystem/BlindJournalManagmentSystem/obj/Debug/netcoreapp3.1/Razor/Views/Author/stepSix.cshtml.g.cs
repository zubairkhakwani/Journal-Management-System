#pragma checksum "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c9444d085212db91f816e671b73834bd2071274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_stepSix), @"mvc.1.0.view", @"/Views/Author/stepSix.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9444d085212db91f816e671b73834bd2071274", @"/Views/Author/stepSix.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261d1804d98ff39377fd12985c97bef143152356", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_stepSix : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlindJournalManagmentSystem.ViewModels.StepSixViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AuthorSideBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_FormValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
  
    ViewBag.Title = "stepSix";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-4\" style=\"padding:35px; \">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c9444d085212db91f816e671b73834bd20712744937", async() => {
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
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n<div class=\"col-sm-8\">\r\n    <div id=\"6\">\r\n");
#nullable restore
#line 12 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
         using (Html.BeginForm("stepsix", "Author", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c9444d085212db91f816e671b73834bd20712746504", async() => {
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
            WriteLiteral(@"            <h1> <small><b>Step 6: Details & Comments</b></small></h1>
            <p>Enter or paste your cover letter text into the ""Cover Letter"" box below. If you would like to attach a file containing your cover letter, click the ""Browse..."" button, locate your file, and click ""Attach this Cover Letter."" Answer any remaining questions appropriately. When you are finished, click ""Save and Continue.""</p>
            <p>Please note that the cover letter is not visible to reviewers.</p>
            <p> <span class=""required"">*</span> =Required Fields</p>
            <hr class=""hr"">
            <h1> <small>Cover Letter</small></h1>
            <p><b>write Cover letter</b></p>
            <div class=""form-group"">
                <br>
                ");
#nullable restore
#line 26 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
           Write(Html.TextAreaFor(m => m.CoverLetter, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <h1> <small>Funding</small></h1>\r\n            <p><span class=\"required\">*</span>  Is there funding to report for this submission?</p>\r\n            <label class=\"radio-inline\">\r\n                ");
#nullable restore
#line 32 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
           Write(Html.RadioButtonFor(m => m.IsThereFundingToReportForThisSubmission, "Yes"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Yes\r\n            </label>\r\n            <label class=\"radio-inline\">\r\n                ");
#nullable restore
#line 35 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
           Write(Html.RadioButtonFor(m => m.IsThereFundingToReportForThisSubmission, "No"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" NO\r\n            </label><br><br>\r\n");
            WriteLiteral("            <hr class=\"hr2\"><br>\r\n");
            WriteLiteral("            <fieldset class=\"F\">\r\n                <label>");
#nullable restore
#line 41 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
                  Write(Html.EditorFor(m => m.SubmittedSolelyToThisJournal));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"required\">*</span> Confirm that the manuscript has been submitted solely to this journal and is not published, in press, or submitted elsewhere.</label>\r\n            </fieldset><br><br>\r\n");
            WriteLiteral("            <fieldset class=\"F\">\r\n                <p> <span class=\"required\">*</span> Has this manuscript been submitted previously to this journal?</p>\r\n                <div class=\"radio\">\r\n                    <label> ");
#nullable restore
#line 47 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
                       Write(Html.RadioButtonFor(m => m.PreviouslySubmittedRadioButton, "Yes"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Yes</label>\r\n                </div>\r\n                <div class=\"radio\">\r\n                    <label> ");
#nullable restore
#line 50 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
                       Write(Html.RadioButtonFor(m => m.PreviouslySubmittedRadioButton, "No"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" No</label>\r\n                </div><hr>\r\n                <p>If yes, what is the manuscript ID of the previous submission.</p>\r\n                <div class=\"form-group\">\r\n                    <div class=\"col-xs-6\">\r\n                        ");
#nullable restore
#line 55 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
                   Write(Html.TextBoxFor(m => m.PreviouSubmittedArticleId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div><br><br>\r\n                </div>\r\n            </fieldset><br><br>\r\n");
            WriteLiteral(@"            <fieldset class=""F"">
                <p><span class=""required"">*</span> <b>Does your manuscript contain supplementary materials such as multimedia, extended objects, or any other item intended for publication but not included in the main body of the paper? Supplementary materials must go through review and may not be added after acceptance.</b></p><hr>
                <div class=""radio"">
                    <label> ");
#nullable restore
#line 63 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
                       Write(Html.RadioButtonFor(m => m.DoesContainSupplementaryMaterial, "Yes"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Yes</label>\r\n                </div>\r\n                <div class=\"radio\">\r\n                    <label> ");
#nullable restore
#line 66 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
                       Write(Html.RadioButtonFor(m => m.DoesContainSupplementaryMaterial, "No"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" No</label>\r\n                </div>\r\n            </fieldset><br><br><br>\r\n");
            WriteLiteral("            <hr class=\"hr2\">\r\n            <button type=\"submit\" class=\"btn btn-primary pull-right\">Save & Continue <span class=\"glyphicon glyphicon-chevron-right\"></span> </button>\r\n");
#nullable restore
#line 72 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepSix.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlindJournalManagmentSystem.ViewModels.StepSixViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591