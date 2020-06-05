using System;
using System.Collections.Generic;
using System.Text;
using BlindJournalManagmentSystem.Models;
using BlindJournalManagmentSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlindJournalManagmentSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> addresses { get; set; }
        public DbSet<Article> articles { get; set; }
        public DbSet<Field> fields { get; set; }
        public DbSet<Files> files { get; set; }
        public DbSet<Institution> institutions { get; set; }
        public DbSet<SubjectCategory> subjectCategories { get; set; }
        public DbSet<TempArticle> tempArticles { get; set; }
        public DbSet<ArticleReviews> articleReviews { get; set; }
        public DbSet<Questions> questions { get; set; }
        public DbSet<Invitation> invitations { get; set; }

        // Many To Many RelationShips Between
        
            // User And Article 
            // store author and opposed reviewers
        public DbSet<AuthorsAndOpposedReviewers> authorsAndOpposedReviewers { get; set; }

        // User And Fields
        // Store Fields Of A User experties
        public DbSet<UserFields> userFields { get; set; }

        // Article and Subject
        // Store categories of an article
        public DbSet<ArticleSubjectCategories> articleSubjectCategories { get; set; }

        // Article And Field
        // Store the field that a user have to review this article
        public DbSet<ReviewerFields> reviewerFields { get; set; }

    }
}
