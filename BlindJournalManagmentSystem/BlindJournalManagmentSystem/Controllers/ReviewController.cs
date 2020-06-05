using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlindJournalManagmentSystem.Data;
using BlindJournalManagmentSystem.Models;
using BlindJournalManagmentSystem.ViewModels.Review;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlindJournalManagmentSystem.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ReviewController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Route("review")]
        [Route("review/invitations")]
        public IActionResult Index()
        {
            return View(initializeInvitationsListByStatus("pending"));
        }

        [HttpPost]
        public IActionResult actionOnInvitation(int id,string action)
        {
            // id = invitaion id
            if(id == 0 || action == "")
            {
                // return to error page;
            }

            Invitation invitation = dbContext.invitations.Find(id);
            if(invitation != null)
            {
                if(action == "0")
                {
                    TempData["err"] = "Select Action Value";
                    return View("index",initializeInvitationsListByStatus("pending"));
                }
                else if (action == "1")
                {
                    invitation.status = "accepted";
                }
                else if(action == "2")
                {
                    invitation.status = "rejected";
                }
                else
                {
                    TempData["err"] = "Invalid Selection";
                    return View("index", initializeInvitationsListByStatus("pending"));
                }
                dbContext.SaveChanges();
            }
            TempData["msg"] = "Updated";
            return RedirectToAction("index");
        }

        public IActionResult articelsToReview()
        {
            return View(initializeInvitationsListByStatus("accepted"));
        }

        public IActionResult review(int id)
        {
            if(id == 0)
            {
                // redirect to error page
            }
            // Getting Invitation Id 
            string LoggedInUserId = dbContext.Users.SingleOrDefault(u => u.UserName == User.Identity.Name).Id;
            int invitationId = dbContext.invitations.SingleOrDefault(i => i.ArticleId == id && i.UserId == LoggedInUserId).Id;
            if (invitationId == 0)
            {
                return Content("You're Not Authorized To Review This Article");
            }

            Article article = dbContext.articles.SingleOrDefault(a => a.Id == id);
            reviewViewModel viewModel = new reviewViewModel()
            {
                ArticleId = article.Id,
                Abstract = article.Abstract,
                CoverLetter = article.CoverLetter,
                DeosContainSupplementaryMaterial = article.DeosContainSupplementaryMaterial,
                IsFunded = article.IsFunded,
                Title = article.Title,
                Type = article.Type,
                questions = dbContext.questions.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult review(int id, Dictionary<int,string> answers)
        {
            // Getting Invitation Id 
            string LoggedInUserId = dbContext.Users.SingleOrDefault(u => u.UserName == User.Identity.Name).Id;
            Invitation invitation = dbContext.invitations.SingleOrDefault(i => i.ArticleId == id && i.UserId == LoggedInUserId);
            if(invitation.Id == 0)
            {
                return Content("You're Not Authorized To Review This Article");
            }
            
            List<Questions> questions = dbContext.questions.ToList();
            if(answers.Count != questions.Count)
            {
                ModelState.AddModelError("", "All Question Are Required");
                return View();
            }

            foreach(Questions question in questions)
            {
                ArticleReviews reviews = new ArticleReviews()
                {
                    invitationid = invitation.Id, 
                    questionid = question.Id,
                    answer = answers[question.Id],
                };
                dbContext.articleReviews.Add(reviews);
                dbContext.SaveChanges();
            }
            invitation.status = "reviewSubmitted";
            dbContext.SaveChanges();

            TempData["msg"] = "Successfully Submitted Review";
            return RedirectToAction("articelsToReview");
        }

        private IList<ReviewInvitationViewModel> initializeInvitationsListByStatus(string status)
        {
            IList<Invitation> invitationsList = dbContext.invitations
                                                         .Include(i => i.Article.Files)
                                                         .Include("Article.AuthorsAndOpposedReviewers.User")
                                                         .Where(i => i.User.UserName == User.Identity.Name && i.status == status).ToList();

            List<ReviewInvitationViewModel> reviewInvitations = new List<ReviewInvitationViewModel>();

            foreach (Invitation invitation in invitationsList)
            {
                ReviewInvitationViewModel reviewInvitation = new ReviewInvitationViewModel()
                {
                    invitationId = invitation.Id,
                    ArticleId = invitation.ArticleId,
                    ArticleTitle = invitation.Article.Title,
                    Authors = invitation.Article.AuthorsAndOpposedReviewers.Where(ao => ao.role == "coAuthor").Select(ao => ao.User.FirstName).ToList(),
                    Files = invitation.Article.Files.Select(f => f.File).ToList()
                };
                reviewInvitations.Add(reviewInvitation);
            }
            return reviewInvitations;
        }
        
        public IActionResult myReviews()
        {
            List<Invitation> a = dbContext.invitations
                .Include(i => i.ArticleReviews)
                .Include("Article.AuthorsAndOpposedReviewers.User")
                .Include(i => i.User)
                .Where(i => i.status == "reviewSubmitted" && i.User.Email == User.Identity.Name).ToList();
            return View(a);
        }
    }
}