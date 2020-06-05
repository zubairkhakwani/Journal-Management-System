using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.Models
{
    //invite authors to review
    public class Invitation
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        [ForeignKey("User")]
        [Required]
        public string UserId { get; set; }
        public Article Article { get; set; }
        [ForeignKey("Article")]
        [Required]
        public int ArticleId { get; set; }
        [Required]
        public string status { get; set; }

        public bool readByAssociateEditor { get; set; }
        public bool readByAuthor { get; set; }

        // Navigation Properties
        public IList<ArticleReviews> ArticleReviews { get; set; }
    }
}
