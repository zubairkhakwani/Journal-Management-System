using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.Models;

namespace BlindJournalManagmentSystem.Models
{
    public class AuthorsAndOpposedReviewers
    {
        public int Id { get; set; }

        public Article Article { get; set; }
        [ForeignKey("Article")]
        [Required]
        public int ArticleId { get; set; }

        
        public ApplicationUser User { get; set; }
        [ForeignKey("User")]
        [Required]
        public string UserId { get; set; }

        [Required]
        public string role { get; set; }
    }
}