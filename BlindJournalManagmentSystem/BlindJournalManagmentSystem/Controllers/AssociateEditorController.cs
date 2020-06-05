using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlindJournalManagmentSystem.Data;
using BlindJournalManagmentSystem.Models;
using BlindJournalManagmentSystem.Services;
using BlindJournalManagmentSystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlindJournalManagmentSystem.Controllers
{
    [Authorize(Roles = "AssociateEditor")]
    public class AssociateEditorController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public AssociateEditorController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Article> articles = dbContext.articles
                                               .Include(a=>a.invitations)
                                               .Include(a => a.AuthorsAndOpposedReviewers)
                                               .Where(a=>a.invitations.Count == 0)
                                               .ToList();

            AssociateEditorIndexViewModel viewModel = new AssociateEditorIndexViewModel()
            {
                articles = articles,
            };

            return View(viewModel);
        }

        public IActionResult ArticlesAssignedToReview()
        {
            IList<Article> articles = dbContext.articles
                                                .Include(a => a.invitations)
                                                .Include(a => a.AuthorsAndOpposedReviewers)
                                                .Where(a => a.invitations.Count != 0)
                                                .ToList();

            AssociateEditorIndexViewModel viewModel = new AssociateEditorIndexViewModel()
            {
                articles = articles,
            };

            return View(viewModel);
        }
        public IActionResult Article(int id)
        {
            AssociateEditorArticleViewModel viewModel = new AssociateEditorArticleViewModel();

            viewModel.article = dbContext.articles.Include(a => a.AuthorsAndOpposedReviewers)
                                                  .Include(a => a.reviewerFields)
                                                  .SingleOrDefault(a => a.Id == id);
            // this or we can simply write "reviewerFields.field" in include method
            viewModel.article.reviewerFields = dbContext.reviewerFields
                                                        .Include(r => r.field)
                                                        .Where(rf => rf.articleId == viewModel.article.Id)
                                                        .ToList();
            // this or we can simply write "AuthorsAndOpposedReviewers.User" in include method
            viewModel.article.AuthorsAndOpposedReviewers = dbContext.authorsAndOpposedReviewers
                                                                    .Where(a => a.ArticleId == viewModel.article.Id)
                                                                    .Include(a => a.User)
                                                                    .Include(a=>a.User.institution)
                                                                    .ToList();

            IList<string> emails = viewModel.article.AuthorsAndOpposedReviewers.Where(ao=>ao.role == "coAuthor").Select(a => a.User.Email).ToList();

            viewModel.users = dbContext.Users.Where(u=>!emails.Contains(u.Email))
                                             .Include(u => u.institution.address)
                                             // because userFields is a list and we can't load its related entities Fields so we use string as a parameter
                                             //.Include(u=>u.userFields)
                                             .Include("userFields.Fields")
                                             .ToList();

            viewModel.invitedReviewers = dbContext.invitations.Include(i=>i.User).Where(a => a.ArticleId == id).ToList();

            viewModel.authorsAndOpposedReviewers = dbContext.authorsAndOpposedReviewers
                                                            .Include(ao => ao.User)
                                                            .ToList();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AssignReviewer(int id,IList<string> reviewersEmails)
        {
            // id = ArticleId
            if(id == 0)
            {
                TempData["title"] = "Error Occured";
                TempData["description"] = "Error Description";
                return RedirectToAction("error", "home");
            }
            else if(reviewersEmails.Count == 0)
            {
                TempData["err"] = "Atleast Select One User To Review";
                return RedirectToAction("article",new { id=id});
            }
            else if(reviewersEmails.Count != reviewersEmails.Distinct().Count())
            {
                TempData["err"] = "Email Repeated Twice";
                return RedirectToAction("article", new { id = id });
            }

            IList<Invitation> alreadyInvitedList = dbContext.invitations.Include(ar=>ar.User).Where(a => a.ArticleId == id).ToList();

            foreach(string email in reviewersEmails)
            {
                if(alreadyInvitedList.SingleOrDefault(a=>a.User.Email.Equals(email)) == null)
                {
                    Invitation invitation = new Invitation()
                    {
                        ArticleId = id,
                        UserId = dbContext.Users.SingleOrDefault(u => u.Email == email).Id,
                        status = "pending",
                        readByAssociateEditor = false,
                        readByAuthor = false
                    };
                    dbContext.invitations.Add(invitation);
                    
                    CustomEmailService emailService = new CustomEmailService();
                    emailService.sendEmail(
                        "zbrkhakwani@gmail.com",
                        "zkpagebuyerandseller",
                        email,
                        "Invitaion To Review An Article",
                        "You're invited To Review An Article Please Login To BJMS Portal For Detail"
                        );
                }
            }

            foreach(Invitation invitation1 in alreadyInvitedList)
            {
                if(!reviewersEmails.Contains(invitation1.User.Email))
                {
                    dbContext.invitations.Remove(invitation1);
                }
            }
            dbContext.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult reviewerComments()
        {
            //List<ArticleReviews> articleReviews = dbContext.articleReviews.Include(ar => ar.invitation).Distinct().Include(ar => ar.invitation.Article).Where(ar => ar.invitation.status == "reviewSubmitted").ToList();
            List<Invitation> a = dbContext.invitations
                .Include(i=>i.ArticleReviews)
                .Include("Article.AuthorsAndOpposedReviewers.User")
                .Include(i=>i.User)
                .Where(i=>i.status == "reviewSubmitted" && i.readByAssociateEditor == false).ToList();
            return View(a);
        }

        public IActionResult actionOnReviewerComment(int invitationId,string action)
        {
            Invitation invitation = dbContext.invitations
                                    .Include(i => i.Article)
                                    .SingleOrDefault(i => i.Id == invitationId);
            if(invitation != null)
            {
                if(action == "approveArticle")
                {
                    invitation.Article.Status = "approved";
                }
                invitation.readByAssociateEditor = true;
                dbContext.SaveChanges();
                TempData["msg"] = "List Updated";
                return RedirectToAction("reviewerComments");
            }
            TempData["err"] = "Invalid Invitation Id";
            return RedirectToAction("reviewerComments");
        }
    }
}
 