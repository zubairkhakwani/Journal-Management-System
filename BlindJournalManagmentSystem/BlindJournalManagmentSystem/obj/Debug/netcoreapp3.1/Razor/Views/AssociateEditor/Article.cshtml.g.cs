#pragma checksum "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f953d49ef3cff593deb44ffdecbfe5892c4d54d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AssociateEditor_Article), @"mvc.1.0.view", @"/Views/AssociateEditor/Article.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f953d49ef3cff593deb44ffdecbfe5892c4d54d2", @"/Views/AssociateEditor/Article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261d1804d98ff39377fd12985c97bef143152356", @"/Views/_ViewImports.cshtml")]
    public class Views_AssociateEditor_Article : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssociateEditorArticleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignReviewer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AssociateEditor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/addReviewersnIntoInviteTable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
  
    List<string> AuthorsEmails = new List<string>();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-sm-4\">\r\n    <h3>Article Detail</h3>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Title</dt>\r\n        <dd>");
#nullable restore
#line 13 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
       Write(Model.article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Abstract</dt>\r\n        <dd>");
#nullable restore
#line 16 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
       Write(Model.article.Abstract);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Status</dt>\r\n        <dd>");
#nullable restore
#line 19 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
       Write(Model.article.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>\r\n\r\n<div class=\"col-sm-4\">\r\n    <h3>Authors</h3>\r\n\r\n    <dl class=\"dl-horizontal\">\r\n");
#nullable restore
#line 27 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
         foreach (AuthorsAndOpposedReviewers author in Model.article.AuthorsAndOpposedReviewers)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
             if (author.role == "coAuthor")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt>");
#nullable restore
#line 31 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
               Write(author.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n                <dd>");
#nullable restore
#line 32 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
               Write(author.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 33 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                AuthorsEmails.Add(author.User.Email);
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n\r\n<div class=\"col-sm-4\">\r\n    <h3>Opposed Reviewers</h3>\r\n\r\n    <dl class=\"dl-horizontal\">\r\n");
#nullable restore
#line 43 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
         foreach (AuthorsAndOpposedReviewers author in Model.article.AuthorsAndOpposedReviewers)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
             if (author.role == "opposerReviewer")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt>");
#nullable restore
#line 47 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
               Write(author.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n                <dd>");
#nullable restore
#line 48 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
               Write(author.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 49 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n<div class=\"col-sm-12\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f953d49ef3cff593deb44ffdecbfe5892c4d54d210935", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 61 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
   Write(Html.Partial("_SuccessErrorPartialView"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <table class=""table"" id=""inviteTable"">
            <h3>Invited Authors List</h3>
            <thead>
                <tr>
                    <th>Email</th>
                    <th>Request Status</th>
                    <th>Remove</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 72 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                 foreach (Invitation invitaion in Model.invitedReviewers)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <input name=\"reviewersEmails\" type=\"email\" class=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2156, "\"", 2185, 1);
#nullable restore
#line 76 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
WriteAttributeValue("", 2164, invitaion.User.Email, 2164, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n                            ");
#nullable restore
#line 77 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                       Write(invitaion.User.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 80 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                       Write(invitaion.status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <button class=\"btn btn-danger\" id=\"removeInvite\">remove</button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 86 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                                                                         WriteLiteral(Model.article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <h2>Invite Authors To Review This Article</h2>

    <table class=""table"">
        <thead>
        <td>Email</td>
        <td>First Name / Last Name</td>
        <td>Conflict</td>
        <td>Invite To Review</td>
        </thead>
        <tbody>
");
#nullable restore
#line 102 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
             foreach (ApplicationUser user in Model.users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td id=\"userEmail\">");
#nullable restore
#line 105 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                              Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 106 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
               Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 106 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                                 Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 108 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                      
                        if (Model.article.AuthorsAndOpposedReviewers.Where(ao => ao.role.Equals("coAuthor")).Select(ao => ao.User.institution.Name).Contains(user.institution.Name))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p> \"From Same Institution\" </p>\r\n");
#nullable restore
#line 112 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                        }


                        IList<int> ArticleIdsWhereUserIsCoAuthor =
                            Model.authorsAndOpposedReviewers
                            .Where(ao => ao.User.Email == user.Email && ao.role == "coAuthor")
                            .Select(ao=>ao.ArticleId).ToList();

                        IList<AuthorsAndOpposedReviewers> workedTogetherPreviously = Model.authorsAndOpposedReviewers
                            .Where(ao => ArticleIdsWhereUserIsCoAuthor.Contains(ao.ArticleId) 
                                && AuthorsEmails.Contains(ao.User.Email) && ao.role == "coAuthor")
                            .ToList();

                        if (workedTogetherPreviously.Count != 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p> \"Previously Work Together.\" </p>\r\n");
#nullable restore
#line 128 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                        }

                        if (Model.article.AuthorsAndOpposedReviewers.Where(ao => ao.role == "opposerReviewer").Select(ao => ao.User.Email).Contains(user.Email))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p> \"Author Added This User As Opposed Reviewer\" </p>\r\n");
#nullable restore
#line 133 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                    <td><button class=\"btn btn-primary inviteButton\">Invite</button></td>\r\n                </tr>\r\n");
#nullable restore
#line 138 "C:\Users\Zubair Khakwani\source\repos\BlindJournalManagmentSystem\BlindJournalManagmentSystem\Views\AssociateEditor\Article.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f953d49ef3cff593deb44ffdecbfe5892c4d54d221381", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssociateEditorArticleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
