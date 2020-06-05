using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.Models;
using BlindJournalManagmentSystem.Models;

namespace BlindJournalManagmentSystem.Models
{
    [Table("Articles")]
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        [MaxLength(50)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        [MaxLength(3000)]
        [Display(Name = "CoverLetter")]
        public string CoverLetter { get; set; }

        [Required]
        [StringLength(300)]
        [MaxLength(300)]
        [Display(Name = "Abstract")]
        public string Abstract { get; set; }

        [Required]
        public string IsFunded { get; set; }
        [Required]
        public string DeosContainSupplementaryMaterial { get; set; }

        public string Status { get; set; } = "Pending";

        [ForeignKey("PreviousSubmittedArticle")]
        public int? PreviousSubmittedArticleId { get; set; }
        public Article PreviousSubmittedArticle { get; set; }

        // Navigation Property
        // Many To Many between user and article
        public ICollection<AuthorsAndOpposedReviewers> AuthorsAndOpposedReviewers { get; set; }

        // Many to many between article and subject category 
        public ICollection<ArticleSubjectCategories> articleSubjectCategories { get; set; }

        //Many To Many Between Article And Field
        // Suggested Fields of a reviewer
        public ICollection<ReviewerFields> reviewerFields { get; set; }

        // Many To Many Between Article And ApplicationUser
        
        //public ICollection<ArticleReviews> articleReviews { get; set; }

        // Navigation Property - One To Many With Files
        public ICollection<Files> Files { get; set; }

        //Navigation Property - One To Many With Invitation
        public IList<Invitation> invitations { get; set; }

        internal void Include()
        {
            throw new NotImplementedException();
        }
    }
}