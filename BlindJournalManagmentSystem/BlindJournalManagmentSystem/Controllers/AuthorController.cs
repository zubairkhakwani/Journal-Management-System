using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlindJournalManagmentSystem.ViewModels;
using BlindJournalManagmentSystem.Models;
using System.IO;
using AutoMapper;
using BlindJournalManagmentSystem.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BlindJournalManagmentSystem.Data;
using Microsoft.AspNetCore.Http;
using BlindJournalManagmentSystem.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BlindJournalManagmentSystem.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using BlindJournalManagmentSystem.ViewModels;

namespace BlindJournalManagmentSystem.Controllers
{
    [Authorize]
    public class AuthorController : Controller
    {
        private ApplicationDbContext dbContext;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly GeneratingData generatingData;

        public AuthorController(ApplicationDbContext dbContext,
                                GeneratingData generatingData,
                                IMapper mapper,
                                IHostingEnvironment hostingEnvironment
                                )
        {
            this.dbContext = dbContext;
            _mapper = mapper;
            this.hostingEnvironment = hostingEnvironment;
            this.generatingData = generatingData;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }

        public ActionResult continueSubmission(int id)
        {
            HttpContext.Session.SetInt32("articleId",id);
            return RedirectToAction("stepone","author");
        }

        // GET: Author
        public ActionResult Index()
        {
            HttpContext.Session.Remove("articleId");
            return View();
        }

        public ActionResult incompleteSubmission()
        {
            HttpContext.Session.Remove("articleId");
            IEnumerable<TempArticle> tempArticle = dbContext.tempArticles.ToList();
            IEnumerable<TempArticleViewModel> model = _mapper.Map<IEnumerable<TempArticle>, IEnumerable<TempArticleViewModel>>(tempArticle);
            return View(model);
        }

        public ActionResult beginSubmission()
        {
            return View();
        }

        public ActionResult stepOne()
        {
            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle tempArticle = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);

                StepOneViewModel model = _mapper.Map<TempArticle,StepOneViewModel>(tempArticle);
                if(model != null)
                {
                    model.OpenAccessAgreement = true;
                    model.PlagiarismConfirmation = true;
                    model.DuplicateSubmissionConfirmation = true;
                    model.types = initializeTypesForStepOne();
                }

                return View(model);
            }
            StepOneViewModel modell = new StepOneViewModel()
            {
                types = initializeTypesForStepOne(),
            };
            return View(modell);
        }

        [HttpPost]
        public ActionResult stepOne(StepOneViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.types = initializeTypesForStepOne();
                return View("stepone", model);
            }

            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle article = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);
                article.Type = model.Type;
                article.Title = model.Title;
                article.Abstract = model.Abstract;

                dbContext.SaveChanges();
            }
            else
             {
                TempArticle article = new TempArticle()
                {
                    Type = model.Type,
                    Title = model.Title,
                    Abstract = model.Abstract,
                };

                dbContext.tempArticles.Add(article);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("articleId",article.Id);
            }
            
            return RedirectToAction("steptwo");
        }

        public ActionResult stepTwo()
        {
            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle tempArticle = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);
                //// when we come back to step two after uploadin file
                //// error occur because type of file in TempArticle is String
                //// but in StepTwoViewModel it's IFormFile
                StepTwoViewModel model = _mapper.Map<TempArticle, StepTwoViewModel>(tempArticle);

                return View(model);
            }
            return View();
        }

        [HttpPost]
        public ActionResult stepTwo(StepTwoViewModel model)
        {
            string[] allowedFileTypes = {".pdf",".docx",".html"};
            int index = 0;
            string AllFiles = "";
            string AllDesignation = "";
            bool anyFileUploded = false;
            if(model.Files == null)
            {
                return View(model);
            }
            for(int i=0; i< model.Files.Count(); i++)
            {
                var file = model.Files.ElementAt(i);
                if (file==null && i==0)
                {
                    ModelState.AddModelError("", "First Main File Is A Required File");
                    continue;
                }

                if (file != null)
                {
                    string a = Path.GetExtension(file.FileName);
                    if (!allowedFileTypes.Contains(Path.GetExtension(file.FileName)))
                    {
                        ModelState.AddModelError("", "File Type Not Allowed");
                        continue;
                    }
                    var picUniqueName = string.Format("{0}-{1}{2}"
                            , Path.GetFileNameWithoutExtension(file.FileName)
                            , Guid.NewGuid().ToString("N")
                            , Path.GetExtension(file.FileName));
                    // Creating Destination path
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "files");
                    string filePath = Path.Combine(uploadsFolder, picUniqueName);
                    file.CopyTo(new FileStream(filePath, FileMode.Create));
                    AllFiles += picUniqueName + "-;";
                    AllDesignation += model.Designation.ElementAt(index) + "-;";
                    index++;
                }
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            if(HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle article = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);
                article.Files = AllFiles;
                article.Designation = AllDesignation;

                dbContext.SaveChanges();
            }
            else
            {
                TempArticle article = new TempArticle()
                {
                    Files = AllFiles,
                    Designation = AllDesignation,
                };
                dbContext.tempArticles.Add(article);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("articleId",article.Id);
            }

            return RedirectToAction("stepThree");
        }

        public ActionResult stepThree()
        {
            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle tempArticle = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);
                StepThreeViewModel model = _mapper.Map<TempArticle, StepThreeViewModel>(tempArticle);
                model.AllFields = generatingData.populateFields();
                model.AllSubjectCategories = generatingData.populateSubjectCategories();

                model.FieldsIds = decodeStringToList(tempArticle.FieldsIds);
                model.SubjectCategoriesIds = decodeStringToList(tempArticle.SubjectCategoriesIds);


                return View(model);
            }
            
            StepThreeViewModel stepThree = new StepThreeViewModel()
            {
                AllFields = generatingData.populateFields(),
                AllSubjectCategories = generatingData.populateSubjectCategories()
            };

          return View(stepThree);
        }

        

        [HttpPost]
        public ActionResult stepThree(StepThreeViewModel model)
        {
            if(!ModelState.IsValid)
            {
                model.AllFields = generatingData.populateFields();
                model.AllSubjectCategories = generatingData.populateSubjectCategories();
                return View(model);
            }

            string AllFieldsIds = "";
            string AllSubjectCategoriesIds = "";
            
            foreach(var field in model.FieldsIds)
            {
                AllFieldsIds += field + "-;";
            }

            foreach (var category in model.SubjectCategoriesIds)
            {
                AllSubjectCategoriesIds += category + "-;";
            }

            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle article = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);
                article.FieldsIds = AllFieldsIds;
                article.SubjectCategoriesIds = AllSubjectCategoriesIds;

                dbContext.SaveChanges();
            }
            else
            {
                TempArticle article = new TempArticle()
                {
                    FieldsIds = AllFieldsIds,
                    SubjectCategoriesIds = AllSubjectCategoriesIds,
                };
                dbContext.tempArticles.Add(article);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("articleId",article.Id);
            }
            return RedirectToAction("stepFour");
        }

        public ActionResult stepFour()
        {
            // If i change login to creat article id on begin submission then
            // also need to add login user in if statement as doing in else
            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle tempArticle = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);
                if(tempArticle.AuthorsEmails == null)
                {
                    tempArticle.AuthorsEmails = User.Identity.Name + "-;";
                }
                StepFourViewModel model = _mapper.Map<TempArticle, StepFourViewModel>(tempArticle);
                model.AuthorsEmails = decodeStringToList(tempArticle.AuthorsEmails);
                model.AuthorsInstitutions = initializeUsersInstitutions(model.AuthorsEmails);

                return View(model);
            }
            else
            {
                TempArticle article = new TempArticle()
                {
                    AuthorsEmails = User.Identity.Name + "-;"
                };
                dbContext.tempArticles.Add(article);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("articleId",article.Id);
                return RedirectToAction("stepfour");
            }
        }

        private List<string> initializeUsersInstitutions(List<string> users)
        {
            List<string> institutions = new List<string>();
            if(users != null)
            {
                foreach (string email in users)
                {
                    var result = dbContext.Users.Include(u => u.institution).SingleOrDefault(u => u.Email == email);
                    institutions.Add(result.institution.Name);
                }
            }
            return institutions;
        }

        [HttpPost]
        public ActionResult stepFour(StepFourViewModel model)
        {
            if(model.AuthorsEmails != null && model.AuthorsEmails.GroupBy(a => a).Any(c => c.Count() > 1))
            {
                ModelState.AddModelError("","Same User Repeated");
            }
            if(model.AuthorsEmails != null && !model.AuthorsEmails.Contains(User.Identity.Name))
            {
                ModelState.AddModelError("", "Logged in user must be one of author");
                model.AuthorsEmails.Insert(0, User.Identity.Name);
                
            }
            if(!ModelState.IsValid)
            {
                model.AuthorsInstitutions = initializeUsersInstitutions(model.AuthorsEmails);
                return View(model);
            }

            string coAuthorsEmails = "";
            foreach (var authorEmail in model.AuthorsEmails)
            {
                coAuthorsEmails += authorEmail + "-;";
            }

            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle article = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);
                article.AuthorsEmails = coAuthorsEmails;

                dbContext.SaveChanges();
            }
            else
            {
                TempArticle article = new TempArticle()
                {
                    AuthorsEmails = coAuthorsEmails
                };
                dbContext.tempArticles.Add(article);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("articleId",article.Id);
            }
            return RedirectToAction("stepFive");
        }

        public ActionResult stepFive()
        {
            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle tempArticle = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);

                StepFiveViewModel model = _mapper.Map<TempArticle, StepFiveViewModel>(tempArticle);
                model.OpposedAuthorsEmails = decodeStringToList(tempArticle.OpposedAuthorsEmails);

                model.OpposedAuthorsInstitutions = new List<string>();
                foreach (string email in model.OpposedAuthorsEmails)
                {
                    var result = dbContext.Users.Include(u => u.institution).SingleOrDefault(u => u.Email == email);
                    model.OpposedAuthorsInstitutions.Add(result.institution.Name);
                }
                return View(model);
            }

            return View();
        }

        [HttpPost]
        public ActionResult stepFive(StepFiveViewModel model)
        {
            if (model.OpposedAuthorsEmails != null && model.OpposedAuthorsEmails.GroupBy(a => a).Any(c => c.Count() > 1))
            {
                ModelState.AddModelError("", "Same User Repeated");
            }
            if(!ModelState.IsValid)
            {
                model.OpposedAuthorsInstitutions = initializeUsersInstitutions(model.OpposedAuthorsEmails.ToList());
                return View(model);
            }
            string OpposedAuthorsEmails = "";
            if(model.OpposedAuthorsEmails != null)
            {
                foreach (var authorEmail in model.OpposedAuthorsEmails)
                {
                    OpposedAuthorsEmails += authorEmail + "-;";
                }
            }

            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle article = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);
                article.OpposedAuthorsEmails = OpposedAuthorsEmails;

                dbContext.SaveChanges();
            }
            else
            {
                TempArticle article = new TempArticle()
                {
                    OpposedAuthorsEmails = OpposedAuthorsEmails
                };
                dbContext.tempArticles.Add(article);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("articleId",article.Id);
            }
            return RedirectToAction("stepSix");
        }

        public ActionResult stepSix()
        {
            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle tempArticle = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);

                StepSixViewModel model = _mapper.Map<TempArticle, StepSixViewModel>(tempArticle);

                return View(model);
            }
            return View();
        }

        [HttpPost]
        public ActionResult stepSix(StepSixViewModel model)
        {
            if(model.PreviouslySubmittedRadioButton != null && model.PreviouslySubmittedRadioButton.Equals("Yes") && model.PreviouSubmittedArticleId == null)
            {
                ModelState.AddModelError("","Article Id Is Not Submitted");
            }
            if(model.PreviouslySubmittedRadioButton != null && model.PreviouslySubmittedRadioButton.Equals("No") && model.PreviouSubmittedArticleId != null)
            {
                model.PreviouSubmittedArticleId = null;
            }
            int? previousArticleId = null;
            if (model.PreviouSubmittedArticleId != null)
            {
                try
                {
                    previousArticleId = Int32.Parse(model.PreviouSubmittedArticleId.ToString());
                    Article article = dbContext.articles.SingleOrDefault(a => a.Id == previousArticleId);
                    if (article == null)
                    {
                        ModelState.AddModelError("", "Invalid Previous Article Id");
                    }
                }
                catch(Exception e)
                {
                    ModelState.AddModelError("", "Invalid Previous Article Id");
                }
            }
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            if (HttpContext.Session.GetInt32("articleId") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("articleId");

                TempArticle article = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == id);
                article.CoverLetter = model.CoverLetter;
                article.PreviouSubmittedArticleId = previousArticleId;
                article.IsThereFundingToReportForThisSubmission = model.IsThereFundingToReportForThisSubmission;
                article.DoesContainSupplementaryMaterial = model.DoesContainSupplementaryMaterial;

                dbContext.SaveChanges();
            }
            else
            {
                TempArticle article = new TempArticle()
                {
                    CoverLetter = model.CoverLetter,
                    PreviouSubmittedArticleId = previousArticleId,
                    IsThereFundingToReportForThisSubmission = model.IsThereFundingToReportForThisSubmission,
                    DoesContainSupplementaryMaterial = model.DoesContainSupplementaryMaterial
                };
                dbContext.tempArticles.Add(article);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("articleId",article.Id);
            }

            
            return RedirectToAction("stepSeven");
        }
        public ActionResult stepSeven()
        {
            ////
            if (HttpContext.Session.GetInt32("articleId") == null)
            {
                return RedirectToAction("stepOne");
            }
            int articleId = (int)HttpContext.Session.GetInt32("articleId");
            TempArticle tempArticle = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == articleId);

            List<string> subjectCategories = decodeStringToList(tempArticle.SubjectCategoriesIds);
            List<string> reviewersFieldIds = decodeStringToList(tempArticle.FieldsIds);
            List<string> Files = decodeStringToList(tempArticle.Files);
            List<string> Designations = decodeStringToList(tempArticle.Designation);
            List<string> coAuthors = decodeStringToList(tempArticle.AuthorsEmails);
            List<string> opposedReviewers = decodeStringToList(tempArticle.OpposedAuthorsEmails);

            Article NewArticle = new Article()
            {
                Type = tempArticle.Type,
                Abstract = tempArticle.Abstract,
                Title = tempArticle.Title,
                CoverLetter = tempArticle.CoverLetter,
                IsFunded = tempArticle.IsThereFundingToReportForThisSubmission,
                DeosContainSupplementaryMaterial = (tempArticle.DoesContainSupplementaryMaterial),
                PreviousSubmittedArticleId = tempArticle.PreviouSubmittedArticleId,
                // done this work down
                ////articleSubjectCategories = dbContext.subjectCategories.Where(sc => subjectCategories.Contains(sc.Id.ToString())).ToList(),
                ////ReviewersFields = dbContext.fields.Where(rf => reviewersFieldIds.Contains(rf.Id.ToString())).ToList()
            };
            List<SubjectCategory> subjectCategories1 = dbContext.subjectCategories.Where(sc => subjectCategories.Contains(sc.Id.ToString())).ToList();
            List<ArticleSubjectCategories> ArticleSubjectCategories = new List<ArticleSubjectCategories>();
            foreach (SubjectCategory subjectCategory in subjectCategories1)
            {
                ArticleSubjectCategories articleSubjectCategories = new ArticleSubjectCategories()
                {
                    ArticleId = NewArticle.Id,
                    SubjectCategoryId = subjectCategory.Id
                };
                ArticleSubjectCategories.Add(articleSubjectCategories);
            }
            NewArticle.articleSubjectCategories = ArticleSubjectCategories;

            List<Field> fields = dbContext.fields.Where(rf => reviewersFieldIds.Contains(rf.Id.ToString())).ToList();
            List<ReviewerFields> ReviewerFields = new List<ReviewerFields>();
            foreach (Field field in fields)
            {
                ReviewerFields reviewerFields = new ReviewerFields()
                {
                    articleId = NewArticle.Id,
                    fieldId = field.Id
                };
                ReviewerFields.Add(reviewerFields);
            }
            NewArticle.reviewerFields = ReviewerFields;

            // Add Errors To ModelState If Found Any
            validateArticle(NewArticle);
            List<Files> f = new List<Files>();
            // REMOVE -; FROM every object when decripted
            for (int i = 0; i < Files.Count(); i++)
            {
                Files n = new Files()
                {
                    File = Files.ElementAt(i),
                    Designation = Designations.ElementAt(i),
                };
                f.Add(n);
            }

            List<AuthorsAndOpposedReviewers> authorsAndOpposedReviewers = new List<AuthorsAndOpposedReviewers>();
            for (int i = 0; i < coAuthors.Count(); i++)
            {
                string email = coAuthors.ElementAt(i);
                AuthorsAndOpposedReviewers n = new AuthorsAndOpposedReviewers()
                {
                    UserId = dbContext.Users.SingleOrDefault(u => u.Email.Equals(email)).Id,
                    role = "coAuthor"
                };
                // savechanges is necessary
                dbContext.SaveChanges();
                authorsAndOpposedReviewers.Add(n);
            }

            for (int i = 0; i < opposedReviewers.Count(); i++)
            {
                string email = opposedReviewers.ElementAt(i);
                AuthorsAndOpposedReviewers n = new AuthorsAndOpposedReviewers()
                {
                    UserId = dbContext.Users.SingleOrDefault(u => u.Email.Equals(email)).Id,
                    role = "opposerReviewer"
                };
                dbContext.SaveChanges();
                authorsAndOpposedReviewers.Add(n);

            }

            ArticleViewModel articleViewModel = new ArticleViewModel()
            {
                Article = NewArticle,
                Files = f,
                AuthorsAndOpposedReviewers = authorsAndOpposedReviewers
            };

            TempData["article"] = JsonConvert.SerializeObject(articleViewModel);

            return View(NewArticle);
        }

        public int validateArticle(Article NewArticle)
        {
            int flag = -1;
            if (NewArticle.Type == null)
            {
                ModelState.AddModelError("", "Type Is Required");
                flag = 1;
            }
            if (NewArticle.Abstract == null)
            {
                ModelState.AddModelError("", "Abstract Is Required");
                flag = 1;
            }
            if (NewArticle.Title == null)
            {
                ModelState.AddModelError("", "Title Is Required");
                flag = 1;
            }
            if (NewArticle.IsFunded == null)
            {
                ModelState.AddModelError("", "IsFunded Is Required");
                flag = 1;
            }
            if (NewArticle.DeosContainSupplementaryMaterial == null)
            {
                ModelState.AddModelError("", "Deos Contain Supplementary Material Is Required");
                flag = 1;
            }
            ////
            if (NewArticle.articleSubjectCategories == null || !NewArticle.articleSubjectCategories.Any())
            {
                ModelState.AddModelError("", "Subject Categories Is Required");
                flag = 1;
            }
            if (NewArticle.CoverLetter == null)
            {
                ModelState.AddModelError("", "Cover Letter Is Required");
                flag = 1;
            }
            return flag;
        }

        [HttpPost]
        public ActionResult stepSeven(Article model)
        {
            ModelState.Clear();
            String tempDAtaStr = TempData["article"] as string;
            ArticleViewModel articleViewModel = JsonConvert.DeserializeObject<ArticleViewModel>(tempDAtaStr);
            Article article = articleViewModel.Article;
            int flag = validateArticle(article);
            if (flag == 1)
            {
                TempData["article"] = JsonConvert.SerializeObject(articleViewModel);
                return View();
            }
            dbContext.articles.Add(article);
            dbContext.SaveChanges();

            for (int i = 0; i < articleViewModel.Files.Count(); i++)
            {
                articleViewModel.Files.ElementAt(i).ArticleId = article.Id;
            }

            for (int i = 0; i < articleViewModel.AuthorsAndOpposedReviewers.Count(); i++)
            {
                articleViewModel.AuthorsAndOpposedReviewers.ElementAt(i).ArticleId = article.Id;
            }

            dbContext.files.AddRange(articleViewModel.Files);
            dbContext.SaveChanges();


            dbContext.authorsAndOpposedReviewers.AddRange(articleViewModel.AuthorsAndOpposedReviewers);
            dbContext.SaveChanges();

            IEnumerable<string> coAuthorsIds = articleViewModel.AuthorsAndOpposedReviewers.Where(a => a.role.Equals("coAuthor")).Select(a => a.UserId);
            List<string> emails = dbContext.Users.Where(u => coAuthorsIds.Any(ca => ca.Equals(u.Id))).Select(u => u.UserName).ToList();
            //sendEmailToAuthors(emails);

            TempData["notice"] = "Article Added Successfully";

            int articleId = (int)HttpContext.Session.GetInt32("articleId");
            TempArticle tempArticle = dbContext.tempArticles.SingleOrDefault(ta => ta.Id == articleId);
            dbContext.tempArticles.Remove(tempArticle);
            dbContext.SaveChanges();

            HttpContext.Session.Remove("articleId");
            return RedirectToAction("index");
        }

        public IActionResult reviewerComments()
        {
            List<Invitation> a = dbContext.invitations
                .Include(i => i.ArticleReviews)
                .Include("Article.AuthorsAndOpposedReviewers.User")
                .Include(i => i.User)
                .Where(i => i.Article.AuthorsAndOpposedReviewers.Any(a => a.User.Email == User.Identity.Name && a.role == "coAuthor"))
                .Where(i => i.status == "reviewSubmitted" && i.readByAuthor == false).ToList();

            return View(a);
        }

        public IActionResult actionOnReviewerComment(int invitationId, string action)
        {
            Invitation invitation = dbContext.invitations
                                    .Include(i => i.Article)
                                    .SingleOrDefault(i => i.Id == invitationId);
            if (invitation != null)
            {
                invitation.readByAuthor = true;
                dbContext.SaveChanges();
                TempData["msg"] = "List Updated";
                return RedirectToAction("reviewerComments");
            }
            TempData["err"] = "Invalid Invitation Id";
            return RedirectToAction("reviewerComments");
        }

        public IActionResult myArticles()
        {
            List<Article> articles = dbContext.articles
                .Include("AuthorsAndOpposedReviewers.User")
                .Include(a=>a.Files)
                .Where(a => a.AuthorsAndOpposedReviewers.Any(ar => ar.User.Email == User.Identity.Name))
                .ToList();

            return View(articles);
        }

        //public ActionResult Review()
        //{
        //    return View();
        //}

        [HttpGet]
        public string searchAuthorByEmail(string email)
        {
            var v = dbContext.Users.Include(u => u.institution).Select(u => new
            {
                Email = u.Email,
                Institution = u.institution.Name
            }).SingleOrDefault(u => u.Email.Equals(email));
            var json = JsonConvert.SerializeObject(v);
            ////var json = new JavaScriptSerializer().Serialize(v);
            return json;
        }

        public List<string> decodeStringToList(string stringToDecode)
        {
            if (stringToDecode != null && stringToDecode.Any())
            {
                List<String> decodedList = stringToDecode.Split(new string[] { "-;" }, StringSplitOptions.None).ToList();
                decodedList.RemoveAt(decodedList.Count()-1);
                return decodedList;
            }
            return new List<string>();
        }

        public void sendEmailToAuthors(List<string> emails)
        {
            foreach(var email in emails)
            {
                CustomEmailService emailService = new CustomEmailService();
                emailService.sendEmail(
                    "zbrkhakwani@gmail.com",
                    "zkpagebuyerandseller",
                    email,
                    "your registered",
                    "Success"
                    );
            }
        }

        private List<string> initializeTypesForStepOne()
        {
            List<string> types = new List<string>();
            {
                types.Add("Regular Manuscript");
                types.Add("Society Section: IEEE Broadcast Technology Society Section");
                types.Add("Society Section: IEEE Electronics Packaging Society Section");
                types.Add("Society Section: IEEE Engineering in Medicine and Biology Society Section");
                types.Add("Society Section: IEEE Photonics Society Section");
                types.Add("Society Section: IEEE Power & Energy Society Section");
                types.Add("Society Section: IEEE Reliability Society Section");
                types.Add("Special Section: New Waveform Design and Air-Interface for Future Heterogeneous Network towards 5G");
                types.Add("Special Section: Mission Critical Sensors and Sensor Networks (MC-SSN)");
                types.Add("Special Section: Emerging Trends, Issues and Challenges for Array Signal Processing and Its Applications in Smart City");
                types.Add("Special Section: Software Defined Networks for Energy Internet and Smart Grid Communications");
                types.Add("Special Section: Intelligent and Cognitive Techniques for Internet of Things");
                types.Add("Special Section: Artificial Intelligence for Physical-Layer Wireless Communications");
                types.Add("Special Section: Millimeter-wave and Terahertz Propagation, Channel Modeling and Applications");
                types.Add("Special Section: Data-Enabled Intelligence for Digital Health");
                types.Add("Special Section: Emerging Approaches to Cyber Security");
                types.Add("Special Section: Urban Computing and Intelligence");
                types.Add("Special Section: Additive Manufacturing Security");
                types.Add("Special Section: Information Centric Wireless Networking with Edge Computing for 5G and IoT");
                types.Add("Special Section: Data Mining for Internet of Things");
                types.Add("Special Section: Innovation and Application of Intelligent Processing of Data, Information and Knowledge as Resources in Edge Computing");
                types.Add("Special Section: Deep Learning: Security and Forensics Research Advances and Challenges");
                types.Add("Special Section: Visual Analysis for CPS Data");
                types.Add("Special Section: Millimeter-Wave Communications: New Research Trends and Challenges");
                types.Add("Special Section: Secure Communication for the Next Generation 5G and IoT Networks");
                types.Add("Special Section: Green Communications on Wireless Networks");
                types.Add("Special Section: Emerging Technologies for Energy Internet");
                types.Add("Special Section: Artificial Intelligence in CyberSecurity");
                types.Add("Special Section: Distributed Computing Infrastructure for Cyber-Physical Systems");
                types.Add("Special Section: Security and Privacy in Emerging Decentralized Communication Environments");
                types.Add("Special Section: Uncertainty Quantification in Robotic Applications");
                types.Add("Special Section: Artificial Intelligence Technologies for Electric Power Systems");
                types.Add("Special Section: Intelligent Data Sensing, Collection and Dissemination in Mobile Computing");
                types.Add("Special Section: Smart Health Sensing and Computational Intelligence: From Big Data to Big Impacts");
                types.Add("Special Section: Communication and Fog/Edge Computing Towards Intelligent Connected Vehicles (ICVs)");
                types.Add("Special Section: Innovation and Application of Internet of Things and Emerging Technologies in Smart Sensing");
                types.Add("Special Section: Antenna and Propagation for 5G and Beyond");
                types.Add("Special Section: Advanced Data Mining Methods for Social Computing");
                types.Add("Special Section: Mobile Multimedia: Methodology and Applications");
                types.Add("Special Section: Advanced Communications and Networking Techniques for Wireless Connected Intelligent Robot Swarms");
                types.Add("Special Section: Deep Learning Algorithms for Internet of Medical Things");
                types.Add("Special Section: Scalable Deep Learning for Big Data");
                types.Add("Special Section: Green Internet of Things");
                types.Add("Special Section: Big Data Technology and Applications in Intelligent Transportation");
                types.Add("Special Section: Advances in Machine Learning and Cognitive Computing for Industry Applications");
                types.Add("Special Section: Complex Networks Analysis and Engineering in 5G and beyond towards 6G");
                types.Add("Special Section: Integrative Computer Vision and Multimedia Analytics");
                types.Add("Special Section: Feature Representation and Learning Methods With Applications in Large-Scale Biological Sequence Analysis");
                types.Add("Special Section: Data Analytics and Artificial Intelligence for Prognostics and Health Management (PHM) Using Disparate Data Streams");
                types.Add("Special Section: Utility Pattern Mining: Theoretical Analytics and Applications");
                types.Add("Special Section: Addressing Challenging Issues of Grids with High Penetration of Grid Connected Power Converters: Towards Future and Smart Grids");
                types.Add("Special Section: Machine Learning Designs, Implementations and Techniques");
                types.Add("Special Section: Artificial Intelligence in Parallel and Distributed Computing");
                types.Add("Special Section: Artificial Intelligence (AI)-Empowered Intelligent Transportation Systems");
                types.Add("Special Section: Intelligent Information Services");
                types.Add("Special Section: Future Generation Smart Cities Research: Services, Applications, Case Studies and Policymaking Considerations for Well-Being [Part II]");
                types.Add("Special Section: Edge Computing and Networking for Ubiquitous AI");
            }
            return types;
        }
    }
}