#pragma checksum "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82d5b29ca3af13424cbf8850b81642919dbffe70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_stepThree), @"mvc.1.0.view", @"/Views/Author/stepThree.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d5b29ca3af13424cbf8850b81642919dbffe70", @"/Views/Author/stepThree.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261d1804d98ff39377fd12985c97bef143152356", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_stepThree : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlindJournalManagmentSystem.ViewModels.StepThreeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AuthorSideBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_FormValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/stepThree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
  
    ViewBag.Title = "stepThree";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-4\" style=\"padding:35px; \">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82d5b29ca3af13424cbf8850b81642919dbffe705466", async() => {
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
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n<div class=\"col-sm-8\">\r\n    <div id=\"3\">\r\n");
#nullable restore
#line 12 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
         using (Html.BeginForm("stepthree", "Author", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82d5b29ca3af13424cbf8850b81642919dbffe707037", async() => {
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
            WriteLiteral(@"            <h1> <small>Step 3:Attributes</small></h1>
            <p>You may enter your manuscript attributes/keywords in two different ways: search the journal's list of keywords by typing in a term and clicking ""Search"" or select your keywords from the list (Control-Click to select multiple words) and click ""Add"". When you are finished, click ""Save and Continue.""</p>
            <p> <span class=""required"">*</span> = Required Fields</p><hr class=""hr"">
");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"FieldsIds\"> (Hold Ctrl To Select More Than One) </label>\r\n                <br>\r\n                ");
#nullable restore
#line 24 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
           Write(Html.DropDownListFor(m => m.UseAsDummy, Model.AllFields, new { @class = "form-control", @id = "FieldsIds", @multiple = "", @style = "height: 140px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <br>
                <button type=""button"" class=""btn btn-primary"" id=""addFields"">
                    <span class=""glyphicon glyphicon-plus""></span>
                    ADD
                </button>

                <br><br>
            </div>
");
            WriteLiteral(@"            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>KEYWORDS: PLEASE CHOOSE KEYWORDS CAREFULLY AS THEY HELP US FIND THE MOST SUITABLE EDITOR TO REVIEW</th>
                    </tr>
                </thead>
                <tbody id=""fieldsTable"">
");
#nullable restore
#line 41 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
                     if (Model.FieldsIds != null)
                    {
                        foreach (var fieldId in Model.FieldsIds)
                        {
                            var id = Int32.Parse(fieldId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <input name=\"FieldsIds\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2202, "\"", 2213, 1);
#nullable restore
#line 48 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
WriteAttributeValue("", 2210, id, 2210, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    ");
#nullable restore
#line 49 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
                               Write(Model.AllFields.SingleOrDefault(af => af.Value == id.ToString()).Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <button type=\"button\" class=\"btn btn-danger\"> remove </button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <hr class=\"hr2\"> <br><br>\r\n            <h1> <small><span class=\"required\">*</span> Subject Category</small></h1>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"SubjectCategoriesIds\"> Please select at least two subject categories that best reflect the scope of your manuscript </label>\r\n                <br>\r\n                ");
#nullable restore
#line 66 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
           Write(Html.DropDownListFor(m => m.UseAsDummy, Model.AllSubjectCategories, new { @class = "form-control", @id = "SubjectCategoriesIds", @multiple = "", @style = "height: 140px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <br>
                <button type=""button"" class=""btn btn-primary"" id=""addCategories"">
                    <span class=""glyphicon glyphicon-plus""></span>
                    ADD
                </button>
                <br><br>
            </div>
");
            WriteLiteral("            <table class=\"table table-striped\">\r\n                <thead>\r\n\r\n                </thead>\r\n                <tbody id=\"categoriesTable\">\r\n");
#nullable restore
#line 80 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
                     if (Model.SubjectCategoriesIds != null)
                    {
                        foreach (var SubjectCategoryId in Model.SubjectCategoriesIds)
                        {
                            var id = Int32.Parse(SubjectCategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <input name=\"SubjectCategoriesIds\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4057, "\"", 4068, 1);
#nullable restore
#line 87 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
WriteAttributeValue("", 4065, id, 4065, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    ");
#nullable restore
#line 88 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
                               Write(Model.AllSubjectCategories.SingleOrDefault(af => af.Value == id.ToString()).Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <button type=\"button\" class=\"btn btn-danger\"> remove </button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 94 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <hr class=\"hr2\">\r\n");
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-primary pull-right\">Save & Continue <span class=\"glyphicon glyphicon-chevron-right\"></span> </button>\r\n");
#nullable restore
#line 102 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\Author\stepThree.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d5b29ca3af13424cbf8850b81642919dbffe7015908", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlindJournalManagmentSystem.ViewModels.StepThreeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
